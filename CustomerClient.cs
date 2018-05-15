using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http.Headers;


using System.Net.Http;namespace WebApiClient.Models
{
    public class CustomerClient
    {
        private string Base_url = "http://localhost:15245/api/";

        public IEnumerable<Customer> FindAll()
        {
            try
            {
                HttpClient Client = new HttpClient();
                Client.BaseAddress = new Uri(Base_url);
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage responce = Client.GetAsync("Customer").Result;
                if (responce.IsSuccessStatusCode)
                    return responce.Content.ReadAsAsync<IEnumerable<Customer>>().Result;
                return null;
            }
            catch
            {
                return null;
            }
        }

        public Customer Find(int Id)
        {
            try
            {
                HttpClient Client = new HttpClient();
                Client.BaseAddress = new Uri(Base_url);
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage responce = Client.GetAsync("Customer/" + Id).Result;
                if (responce.IsSuccessStatusCode)
                    return responce.Content.ReadAsAsync<Customer>().Result;
                return null;
            }
            catch
            {
                return null;
            }
        }
        public bool Create(Customer customer)
        {
            try
            {
                HttpClient Client = new HttpClient();
                Client.BaseAddress = new Uri(Base_url);
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage responce = Client.PostAsJsonAsync("Customer",customer).Result;
                return responce.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }


        public bool Edit(Customer customer)
        {
            try
            {
                HttpClient Client = new HttpClient();
                Client.BaseAddress = new Uri(Base_url);
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage responce = Client.PutAsJsonAsync("Customer/" + customer.Id, customer).Result;
                return responce.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }


        public bool Delete(int id)
        {
            try
            {
                HttpClient Client = new HttpClient();
                Client.BaseAddress = new Uri(Base_url);
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage responce = Client.DeleteAsync("Customer/" + id).Result;
                return responce.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }






    }
}