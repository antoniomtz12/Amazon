﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Amazon.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }

        //public actionresult index()
        //{
        //    var producto = obtenerdetalledelproducto(id);
        //    return view();
        //}


    }
}