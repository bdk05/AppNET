using AppNET.Domain.Entities;
using AppNET.Domain.Entities.Base;
using AppNET.Domain.Interfaces;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Text.Json;

namespace AppNET.Infrastructure.IOToTXT
{
    public class TextFileRepository<T> : IRepository<T> where T : BaseEntity
    {
        private static string FileName 
        { get
            {
                return typeof(T).FullName.Replace(".", "") + ".txt";
            }
            
            
        }
        private static List<T> list = new List<T>();
        private static void LoadListFromFile()
        {
            if(!File.Exists(FileName))
            {
                list=new List<T>();
                return;
            }
            var json=File.ReadAllText(FileName);
            list = JsonSerializer.Deserialize<List<T>>(json);
        }
        static TextFileRepository()
        {
            LoadListFromFile();
        }
        private static void WriteListToTxt()
        {
            var jsonText=JsonSerializer.Serialize(list);
            File.WriteAllText(FileName, jsonText);  
        }

        public T Add(T entity)
        {
            LoadListFromFile();
            list.Add(entity);
            WriteListToTxt();
            return entity;
        }

        public T GetById(int id)
        {
            LoadListFromFile();
            var entity=list.FirstOrDefault(x=>x.Id==id);
            return entity;
        }

        public ICollection<T> GetList(Func<T, bool> expression = null)
        {
            LoadListFromFile();

            return expression==null?list:list.Where(expression).ToList();
            //if (expression==null)
            //{
            //    return list;
            //}
            ////else yazmaya gerek yok çünkü zaten ilk ifadeye girerse retun ile çıkar.
            //    return list.Where(expression).ToList();
            
        }

        public bool Remove(int id)
        {
            LoadListFromFile();
            var deletedEntity=GetById(id);
            if (deletedEntity != null)
            {
                list.Remove(deletedEntity);
                WriteListToTxt();
                return true;
            }
            return false;
            
        }

        public T Update(int id, T entity)
        {
            if (id!=entity.Id)
            {
                throw new ArgumentException("Id değerleri uyuşmuyor");
            }
            LoadListFromFile();
            var updatedEntity = list.FirstOrDefault(x=>x.Id==id);
            if (updatedEntity == null)
            {
                throw new Exception("Verilen id bulunamadi");
            }
            list.Remove(updatedEntity);
            list.Add(entity);
            WriteListToTxt();
            return entity;


        }

       
    }
}