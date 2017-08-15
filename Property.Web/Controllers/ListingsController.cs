using Microsoft.AspNet.Identity;
using Property.Data;
using Property.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Property.Web.Controllers
{
    public class ListingsController : BaseController
    {
        public ActionResult My()
        {
            
            return View(new CurrentlyOnMarketViewModel()
            {
               
            });
        }

        [HttpGet]
        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ListingInputModel model)
        {
            //code for creating
            if (model != null && this.ModelState.IsValid)
            {
                var l = new Listing()
                {
                    Address = model.StreetAddress,
                    forSale = model.ForSale
                };

                db.Listings.Add(l);
                this.db.SaveChanges();
                return this.RedirectToAction("Conf");
            }

            return this.View(model);
        }


        public ActionResult Conf()
        {



            return View();
        }
        //[HttpGet]
        //public ActionResult Edit(int id)
        //{
        //    var ReviewToEdit = this.LoadReview(id);
        //    if (ReviewToEdit == null)
        //    {
        //        return this.RedirectToAction("Index");
        //    }

        //    var model = ListingInputModel.CreateFromListing(ReviewToEdit);
        //    return this.View(model);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, ListingInputModel model)
        //{

        //    //code for editing reviews
        //    var ReviewToEdit = this.LoadReview(id);
        //    if (ReviewToEdit == null)
        //    {
        //        return this.RedirectToAction("Index");
        //    }

        //    if (model != null && this.ModelState.IsValid)
        //    {
        //        ReviewToEdit.Title = model.Title;
        //        //ReviewToEdit.StartDateTime = model.StartDateTime;
        //        //ReviewToEdit.Duration = model.Duration;
        //        ReviewToEdit.Description = model.Description;
        //        ReviewToEdit.Location = model.Location;
        //        ReviewToEdit.IsPublic = model.IsPublic;

        //        this.db.SaveChanges();
        //        return this.RedirectToAction("My");
        //    }

        //    return this.View(model);
        //}

        //[HttpGet]
        //public ActionResult Delete(int id)
        //{
        //    //code for getting a review to delete
        //    var ReviewToDelete = this.LoadReview(id);
        //    if (ReviewToDelete == null)
        //    {
        //        this.AddNotification("Cannot delete Review #" + id, NotificationType.ERROR);
        //        return this.RedirectToAction("My");
        //    }

        //    var model = ReviewInputModel.CreateFromReview(ReviewToDelete);
        //    return this.View(model);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, ReviewInputModel model)
        //{
        //    //code for removing a review from the database 
        //    var ReviewToDelete = this.LoadReview(id);
        //    if (ReviewToDelete == null)
        //    {
        //        this.AddNotification("Cannot delete Review #" + id, NotificationType.ERROR);
        //        return this.RedirectToAction("My");
        //    }

        //    this.db.Reviews.Remove(ReviewToDelete);
        //    this.db.SaveChanges();
        //    this.AddNotification("Review deleted.", NotificationType.INFO);
        //    return this.RedirectToAction("My");
        //}

        //private Review LoadReview(int id)
        //{
        //    //code for loading a review
        //    var currentUserId = this.User.Identity.GetUserId();
        //    var isAdmin = this.IsAdmin();
        //    var ReviewToEdit = this.db.Reviews
        //        .Where(e => e.Id == id)
        //        .FirstOrDefault(e => e.AuthorId == currentUserId || isAdmin);
        //    return ReviewToEdit;
        //}



     
    }
}
