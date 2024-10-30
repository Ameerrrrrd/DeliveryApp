using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Linq;
using test;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CheckConnectionWithDataBase()
        {
            using (var connection = new MySqlConnection("server=127.0.0.1; user=root; database=orders; password="))
            {
                connection.Open();
                Assert.AreEqual(ConnectionState.Open, connection.State);
            }
        }


        private string logFilePath = "testloging.txt";
        [TestMethod]

        public void TestLoggingFunction()
        {
            var delivery = new Delivery();

            string testLogMessage = "This a test logging message!";
            delivery.Log(testLogMessage);

            string logContent = File.ReadAllText(logFilePath);
            StringAssert.Contains(testLogMessage, logContent, "Сообщение не записано в лог");

            var lines = File.ReadAllLines(logFilePath).ToList();

            lines.RemoveAll(line => line.Contains(testLogMessage));
            File.WriteAllLines(logFilePath, lines);
        }


    }
}
