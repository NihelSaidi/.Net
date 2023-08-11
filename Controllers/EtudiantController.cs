using Microsoft.AspNetCore.Mvc;
using EtudiantProject.Models;
using System.Collections.Generic;
namespace EtudiantProject.Controllers
{
    public class EtudiantController : Controller
    {
        public ApplicationDbContext dbContext{get;set;}
        public EtudiantController(ApplicationDbContext _db){
            dbContext=_db;
        }
        public IActionResult getData(){
IEnumerable<Etudiant> listeEtudiants=dbContext.etudiants;
            return View(listeEtudiants);
        }
        public IActionResult create(){
            return View();
        }
        [HttpPost]
        public IActionResult createEtud(Etudiant etud){
       dbContext.Add(etud);
       dbContext.SaveChanges();
       return RedirectToAction("getData");
        }
      
      public IActionResult update(int? id ){
          if ((id==null)||(id==0)){
              return NotFound();
          }
          var obj=dbContext.etudiants.Find(id);
          if(obj==null){
              return NotFound();

          } else{
              return View(obj);
          }

      }
      public IActionResult updatePost(Etudiant obj){
        dbContext.etudiants.Update(obj);
        dbContext.SaveChanges();

return RedirectToAction("getData");

      }
      
  
       public IActionResult delete(int? id ){
           if( (id==null)||(id==0)){
               return NotFound();
           }
               var obj=dbContext.etudiants.Find(id);
               if(obj==null){
                   return NotFound();
               }
               dbContext.etudiants.Remove(obj);
               dbContext.SaveChanges();
               return RedirectToAction("getData");
       }

    }}