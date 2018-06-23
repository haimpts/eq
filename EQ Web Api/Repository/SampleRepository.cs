using EQ_Web_Api.Db;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EQ_Web_Api.Models
{

    
    public static class SampleRepository
    {
        //   public static string data = SampleData.Instace.get();

       
      
        public static List<SampleDataModel> getAllData()
        {
           
            string data = Singleton.Instance.get();
            List<SampleDataModel> allData = JsonConvert.DeserializeObject<List<SampleDataModel>>(data);
            return allData;

        }

        public static SampleDataModel getData(string id)
        {
            string data = Singleton.Instance.get();
            List<SampleDataModel> allData = JsonConvert.DeserializeObject<List<SampleDataModel>>(data);
            SampleDataModel model =  allData.AsEnumerable().Where(a => a.Id == id).FirstOrDefault();
            return model;
        }

        public static void save(SampleDataModel model)
        {
            string data = Singleton.Instance.get();
            List<SampleDataModel> allData = JsonConvert.DeserializeObject<List<SampleDataModel>>(data);
            allData.Add(model);
            string newData = JsonConvert.SerializeObject(allData);
            Singleton.Instance.save(newData);
        }

        public static void delete(string id)
        {
            string data = Singleton.Instance.get();
            List<SampleDataModel> allData = JsonConvert.DeserializeObject<List<SampleDataModel>>(data);
            SampleDataModel model = allData.AsEnumerable().Where(a => a.Id == id).FirstOrDefault();
            allData.Remove(model);
            string newData = JsonConvert.SerializeObject(allData);
            Singleton.Instance.save(newData);
        }

        public static void update(SampleDataModel model)
        {
            string data = Singleton.Instance.get();
            List<SampleDataModel> allData = JsonConvert.DeserializeObject<List<SampleDataModel>>(data);
            SampleDataModel dbModel = allData.AsEnumerable().Where(a => a.Id == model.Id).FirstOrDefault();
            dbModel = model;
            string newData = JsonConvert.SerializeObject(allData);
            Singleton.Instance.save(newData);
        }
    }
}