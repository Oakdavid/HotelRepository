using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infreastructure.Persistence.Context
{
    public class StartUp
    {
        string connectionString = "Sever=localhost; user=root; password=David1234567890";
        string connectionStrings = "Sever=localhost; user=root; password=pa$$word; database=hoteldb";

        string createUser = "create table if not exist user(Id varchar(5), Email varchar(50), Password varchar(50), Role varchar(50), IsDeleted Tinyint, primary key(Id) )";

        string createProfile = "create table if not exist profile(Id varchar(5), UserEmail varchar(50), FirstName varchar(50), LastName varchar(50), Address varchar(50),PhoneNumber varchar(50), IsDeleted Tinyint, primary key(Id), foreign key(UserEmail) references user(email))";

        string createCustomer = "create table if not exist customer(Id varchar(5), UserEmail varchar(50), TagNumber varchar(50), Wallet double, IsDeleted Tinyint, primary key(Id), foreign key(UserEmail) references user(email))";

        string createCategory = "create table if not exist category(Id varchar(5), Name varchar(50), Price double, IsDeleted Tinyint, primary key(Id))";

        string createRoom = "create table if not exist room(Id varchar(5), CategoryName varchar(50), Name varchar(50), IsAvailable tinyint, IsDeleted Tinyint, primary key(Id), foreign key(CategoryName) references category(name))";

        string createBooking = "create table if not exist booking(Id varchar(5), RefNumber varchar(50), UserEmail varchar(50), RoomName varchar(50), IsDeleted Tinyint, primary key(Id), foreign key(UserEmail) references user(email), foreign key RoomName references room(name))";



        public void FirstRun()
        {
            var schemaQry = "create schema if not exist hoteldb";
            using (var con = new MySqlConnection(connectionString))
            {
                var com = new MySqlCommand(schemaQry, con);
                com.ExecuteNonQuery();
            }

            CreateTable(createUser);
            CreateTable(createProfile);
            CreateTable(createCustomer);
            CreateTable(createCategory);
            CreateTable(createRoom);
            CreateTable(createBooking);
        }

        public MySqlConnection Connection()
        {
            return new MySqlConnection(connectionStrings);
        }

        private void CreateTable(string qry)
        {
            using (var con = Connection())
            {
                var com = new MySqlCommand(qry, con);
                com.ExecuteNonQuery();
            }
        }
    }
}
