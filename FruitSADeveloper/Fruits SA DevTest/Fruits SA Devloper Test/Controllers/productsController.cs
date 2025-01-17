﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PagedList;
using Fruits_SA_Devloper_Test.Db;

namespace Fruits_SA_Devloper_Test.Models
{
    public class productsController : Controller
    {
        private productsDatabase db = new productsDatabase();

        // GET: products
        public ActionResult Index()
        {
            using (productsDatabase db = new productsDatabase()) 

                return View(db.Products.ToList());
        }
        public ActionResult ProductList(int? page, int? pageSize)
        {

            int pageIndex = 1;
            pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            int defaSize = (pageSize ?? 10);

            ViewBag.psize = defaSize;
            ViewBag.PageSize = new List<SelectListItem>()
    {
        new SelectListItem() { Value="5", Text= "5" },
        new SelectListItem() { Value="10", Text= "10" },
        new SelectListItem() { Value="15", Text= "15" },
        new SelectListItem() { Value="25", Text= "25" },
        new SelectListItem() { Value="50", Text= "50" },
     };

            productsDatabase db = new productsDatabase();
            IPagedList<product> productsLst = null;
            productsLst = db.Products.OrderBy(x => x.id).ToPagedList(pageIndex, defaSize);


            return View(productsLst);

        }
        // GET: products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,productCode,productName,description,categoryName,price,image")] product product,HttpPostedFileBase file)
        {

            if (ModelState.IsValid)
            {
                string fileName = System.IO.Path.GetFileNameWithoutExtension(product.imageFile.FileName);
                string extension = System.IO.Path.GetExtension(product.imageFile.FileName);
                product.image = "../Files" + fileName;
                fileName = System.IO.Path.Combine(Server.MapPath("../Files/"), fileName);
                product.imageFile.SaveAs(fileName);
                using (productsDatabase db = new productsDatabase())

                    db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ModelState.Clear();
           return View();
        }

        // GET: products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,productCode,productName,description,categoryName,price,image")] product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
