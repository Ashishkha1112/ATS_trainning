
using EDental.Data;
using EDental.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

public class DoctorsController : Controller
{
    public IActionResult Index()
    {
        // Fetch data from doctor table
        // ADO.NET
        // ORM Tool: EF Core, Dapper, NHibernate etc.

        var db = new EDentalDbContext();
        var doctors = db.Doctor.ToList();

        return View(doctors);
    }
    public IActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Add(Doctor doctor)
    {
        var db = new EDentalDbContext();
        var doctors = db.Doctor.Add(doctor);
        db.SaveChanges();
        return RedirectToAction("Index");
    }
    [HttpDelete]
    public IActionResult Delete(int id)
    {
        var db = new EDentalDbContext();
        var doctor = db.Doctor.Find(id);

        if (doctor != null)
        {
            // Remove the doctor entity
            db.Doctor.Remove(doctor);
            db.SaveChanges(); // Save the changes
           
        }
        return RedirectToAction("Index");

    }



}