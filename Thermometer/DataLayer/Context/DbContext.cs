using System.Collections.Generic;
using System.Windows.Forms;
using SQLite;
using System.IO;
using DataLayer.Models;

namespace DataLayer.Context
{
    public class DbContext
    {
        SQLiteConnection db;

        public DbContext()
        {
            string FileNameDB = Application.StartupPath + "/DataBase/Thermometer.db";

            if (File.Exists(FileNameDB))
            {

                db = new SQLiteConnection($@"{FileNameDB}");
            }
            else
            {
                db = new SQLiteConnection($@"{FileNameDB}");
                db.CreateTable<Sensors>();
                db.CreateTable<SetValueSensors>();
            }
        }

        public void insertData(Sensors data)
        {
            db.Insert(data);
            db.Close();
        }

        public void update(SetValueSensors data)
        {
            db.Query<SetValueSensors>($"update SetValueSensors set MaxTemperature = {data.MaxTemperature},MinTemperature = {data.MinTemperature},MaxHumidity = {data.MaxHumidity},MinHumidity = {data.MinHumidity},MaxWetness = {data.MaxWetness}, MinWetness = {data.MinWetness}");
            db.Close();
        }
        public IEnumerable<value> GetAllData()
        {
            return db.Query<value>("select * from sensors");
        }
        public IEnumerable<SetValueSensors> GetAllDataValue()
        {
            return db.Query<SetValueSensors>("select * from setvaluesensors");
        }
        public void Dispose()
        {
            db.Dispose();
            
        }

        
        

    }
    public class value
    {
        public string temperature { get; set; }
        public string humidity { get; set; }
        public string Wetness { get; set; }
        public string DataTime { get; set; }

    }

}
