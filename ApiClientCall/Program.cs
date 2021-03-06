﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using ApiClientCall;
using Dto;
using System.IO;

namespace ApiClientCall
{
    class Program
    {
        //https://docs.microsoft.com/it-it/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client
        static void Main(string[] args)
        {
           
            //RunAsync3().GetAwaiter().GetResult();


            ////---------------
            //string url2 = "http://2.235.241.7:8080/bank-report-entries/2/upload";
            //string fullPath2 = @"C:\GIT_LUCA\re2017\Re2017Software\Checking3-19.csv";
            ////FileStream fs = File.Create(fullPath2);
            //Task<HttpResponseMessage> tskRM = UploadImage(url2, File.ReadAllBytes(fullPath2));
            //HttpResponseMessage RM = tskRM.Result;


            //-----------
            
            //     string url3 = "http://2.235.241.7:8080/bank-report-entries/2/upload";
            //string fullPath3 = @"C:\GIT_LUCA\re2017\Re2017Software\Checking3-19.csv";
            ////FileStream fs = File.Create(fullPath2);
            //Task<HttpResponseMessage> tskRM3 = UploadImageB(url3, fullPath3);
            //HttpResponseMessage RM3 = tskRM3.Result;

            GetRequest("http://2.235.241.7:8080/banks");
            Console.ReadKey();
        }
        //async static void PostRequest(string Url)
        //{
        //    HttpContent q = new MultipartFormDataContent();
        //    q.
        //    using (HttpClient client = new HttpClient())
        //    {
        //        using (HttpResponseMessage response = await client.PostAsync(Url, object)
        //        {
        //            using (HttpContent content = response.Content)
        //            {
        //                string mycont = await content.ReadAsStringAsync();
        //            }
        //        }
        //    }
        //}
        async static void GetRequest(string Url)
        {
            
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(Url))
                {
                    using (HttpContent content = response.Content)
                    {
                        string mycont = await content.ReadAsStringAsync();
                        Console.Write(mycont);
                    }
                }
            }
        }
        static async  Task<HttpResponseMessage> UploadImage(string url, byte[] ImageData)
        {
            HttpClient client = new HttpClient();
            var requestContent = new MultipartFormDataContent();
            HttpContent stringContent = new StringContent("2");
            //    here you can specify boundary if you need---^
            //var streamContent = new StreamContent(File.Open(fileName, FileMode.Open));
            var imageContent = new ByteArrayContent(ImageData);
            imageContent.Headers.ContentType =
                MediaTypeHeaderValue.Parse("image/jpeg");

            requestContent.Add(stringContent, "bankId", "2");
            requestContent.Add(imageContent, "image", "image.jpg");

            return await client.PostAsync(url, requestContent);
        }
        static async Task<HttpResponseMessage> UploadImageB(string url, string FullPathImage)
        {
            HttpClient client = new HttpClient();
            var requestContent = new MultipartFormDataContent();
            HttpContent stringContent = new StringContent("2");
            //    here you can specify boundary if you need---^
            var streamContent = new StreamContent(File.Open(FullPathImage, FileMode.Open));
            //var imageContent = new ByteArrayContent(ImageData);
            //imageContent.Headers.ContentType =
            //MediaTypeHeaderValue.Parse("image/jpeg");
            requestContent.Add(stringContent, "bankId");
            requestContent.Add(streamContent, "file");
            //requestContent.Add(imageContent, "image", "image.jpg");

            return await client.PostAsync(url, requestContent);
        }
        static HttpClient client = new HttpClient();

        static void ShowProduct(Product product)
        {
            Console.WriteLine($"Name: {product.Name}\tPrice: " +
                $"{product.Price}\tCategory: {product.Category}");
        }
        static async Task<Uri> CreateProductAsync(Product product)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api/products", product);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        static async Task<Product> GetProductAsync(string path)
        {
            Product product = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<Product>();
            }
            return product;
        }
        static async Task<ContainerDTO> GetProductAsync2(string path)
        {
            ContainerDTO ObjContainerDTO = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                ObjContainerDTO = await response.Content.ReadAsAsync<ContainerDTO>();
            }
            return ObjContainerDTO;
        }
        static async Task<List<Evento>> GetEventAsync3(string path)
        {
            List<Evento>LstEvento = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                LstEvento = await response.Content.ReadAsAsync<List<Evento>>();
            }
            return LstEvento;
        }
        static async Task<Product> UpdateProductAsync(Product product)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"api/products/{product.Id}", product);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            product = await response.Content.ReadAsAsync<Product>();
            return product;
        }
        static async Task<HttpStatusCode> DeleteProductAsync(string id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"api/products/{id}");
            return response.StatusCode;
        }
        static async Task RunAsync2()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://localhost:50692/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                //// Create a new product
                //Product product = new Product
                //{
                //    Name = "Gizmo",
                //    Price = 100,
                //    Category = "Widgets"
                //};

                //var url = await CreateProductAsync(product);
                //Console.WriteLine($"Created at {url}");
                // var url = "api/products";
                // Get the product
                ContainerDTO ObjContainerDTO = new ContainerDTO();
                ObjContainerDTO = await GetProductAsync2("api/Utenti/GetUser?IdUser=36");
                //ShowProduct(product);

                //// Update the product
                //Console.WriteLine("Updating price...");
                //product.Price = 80;
                //await UpdateProductAsync(product);

                //// Get the updated product
                //product = await GetProductAsync(url.PathAndQuery);
                //ShowProduct(product);

                //// Delete the product
                //var statusCode = await DeleteProductAsync(product.Id);
                //Console.WriteLine($"Deleted (HTTP Status = {(int)statusCode})");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        static async Task RunAsync3()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://2.235.241.7:8080/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                //// Create a new product
                //Product product = new Product
                //{
                //    Name = "Gizmo",
                //    Price = 100,
                //    Category = "Widgets"
                //};

                //var url = await CreateProductAsync(product);
                //Console.WriteLine($"Created at {url}");
                // var url = "api/products";
                // Get the product
                ContainerDTO ObjContainerDTO = new ContainerDTO();
                List<Evento> LstEvento = new List<Evento>();
                LstEvento = await GetEventAsync3("events?startDate=2018-08-01&endDate=2018-09-10");
                //ShowProduct(product);

                //// Update the product
                //Console.WriteLine("Updating price...");
                //product.Price = 80;
                //await UpdateProductAsync(product);

                //// Get the updated product
                //product = await GetProductAsync(url.PathAndQuery);
                //ShowProduct(product);

                //// Delete the product
                //var statusCode = await DeleteProductAsync(product.Id);
                //Console.WriteLine($"Deleted (HTTP Status = {(int)statusCode})");
                foreach (Evento Evt in LstEvento)
                {
                    Console.WriteLine(Evt.description + " " + Evt.amount);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
        static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://localhost:64195/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                // Create a new product
                Product product = new Product
                {
                    Name = "Gizmo",
                    Price = 100,
                    Category = "Widgets"
                };

                var url = await CreateProductAsync(product);
                Console.WriteLine($"Created at {url}");

                // Get the product
                product = await GetProductAsync(url.PathAndQuery);
                ShowProduct(product);

                // Update the product
                Console.WriteLine("Updating price...");
                product.Price = 80;
                await UpdateProductAsync(product);

                // Get the updated product
                product = await GetProductAsync(url.PathAndQuery);
                ShowProduct(product);

                // Delete the product
                var statusCode = await DeleteProductAsync(product.Id);
                Console.WriteLine($"Deleted (HTTP Status = {(int)statusCode})");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
