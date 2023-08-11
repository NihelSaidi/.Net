using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace EtudiantProject.Models
{
    public class ApplicationDbContext:DbContext
    {
public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options){

}

public DbSet<Etudiant> etudiants{get;set;}}
    }