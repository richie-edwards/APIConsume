using SWAPITestDriveLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SWAPITestDriveLibrary
{
    public  class SwApiProcessor
    {
        public static async Task<Object> LoadData(Resource resource, string id = "")
        {
            //PeopleModel model = new PeopleModel();
            string url = ApiHelper.ApiClient.BaseAddress.ToString() + $"{resource.ToString().ToLower()}/{id}";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                var model = new Model();
                if (response.IsSuccessStatusCode)
                {                    
                    switch (resource)
                    {                        
                        case Resource.vehicles:
                            model = await response.Content.ReadAsAsync<VehicleModel>();
                            break;
                        case Resource.people:
                            model = await response.Content.ReadAsAsync<PeopleModel>();
                            break;
                        case Resource.films:
                            model = await response.Content.ReadAsAsync<PeopleModel>();
                            break;
                        case Resource.spaceships:
                            model = await response.Content.ReadAsAsync<PeopleModel>();
                            break;
                        case Resource.planets:
                            model = await response.Content.ReadAsAsync<PeopleModel>();
                            break;
                        case Resource.species:
                            model = await response.Content.ReadAsAsync<PeopleModel>();
                            break;
                        default:
                            break;
                    }                    
                    return model;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

    }

    public enum Resource
    {
        vehicles,
        people,
        films,
        spaceships,
        planets,
        species
    }
}
