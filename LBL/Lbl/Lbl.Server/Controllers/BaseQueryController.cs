﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lbl.Server.Controllers
{
    using Lbl.Model;
    using Lbl.RequestModel;
    using Lbl.Service;
    using Lbl.ViewModel;

    public class BaseQueryController<T, TR, TV> : ApiController where T : Entity where TR : BaseRequestModel<T> where TV : BaseViewModel<T>
    {
        [Route("Search")]
        [ActionName("Search")]
        [HttpPost]
        public IHttpActionResult Search(TR request)
        {
            var service = new BaseService<T, TR, TV>();
            var students = service.Search(request);
            return this.Ok(students);
        }
    }
}
