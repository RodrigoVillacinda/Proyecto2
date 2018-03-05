using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Lab2.Models;

namespace Lab2.Controllers
{
    public class ArbolCadenaController : Controller
    {
        // GET: ArbolCadena
        public ActionResult Index()
        {
            ArbolEntero entero = new ArbolEntero();

            var path = @"D:\Descargas\dataCadena.json";
            var enteros = System.IO.File.ReadAllText(path);

            //Recibe un objeto generico, agarramos la cadena de texto de Json
            // y lo convertimos en un objeto

            var arbolenteros = JsonConvert.DeserializeObject<ArbolEntero>(enteros);

            var cadena = JsonConvert.SerializeObject(arbolenteros);

            TempData["Arbol"] = cadena;
            TempData.Keep();
            return View();

        }

        // GET: ArbolCadena/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ArbolCadena/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArbolCadena/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ArbolCadena/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ArbolCadena/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ArbolCadena/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ArbolCadena/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
