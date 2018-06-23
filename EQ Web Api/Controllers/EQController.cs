using EQ_Web_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EQ_Web_Api.Controllers
{
    public class EQController : ApiController
    {
        // GET: api/EQ
        public IEnumerable<SampleDataModel> Get()
        {
            return SampleRepository.getAllData();
        }

        // GET: api/EQ/3f2b12b8-2a06-45b4-b057-45949279b4e5
        public SampleDataModel Get(string id)
        {
            return SampleRepository.getData(id);

        }

        // POST: api/EQ
        public HttpResponseMessage Post([FromBody]SampleDataModel model)
        {
            try {
                SampleRepository.save(model);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);

            }
        }

        // PUT: api/EQ
        public HttpResponseMessage Put([FromBody]SampleDataModel model)
        {
            try
            {
                SampleRepository.update(model);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);

            }
        }

        // DELETE: api/EQ/3f2b12b8-2a06-45b4-b057-45949279b4e5
        public HttpResponseMessage Delete(string id)
        {
            try
            {
                SampleRepository.delete(id);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);

            }
        }
    }
}
