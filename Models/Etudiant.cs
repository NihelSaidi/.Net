using System;
using System.ComponentModel.DataAnnotations;

namespace EtudiantProject.Models
{
    public class Etudiant
    {
  [Key]      
public int id{get;set;}
public string nom{get;set;}
public string adresse{get;set;}
public string dateNaiss{get;set;}
public string niveau{get;set;}

    }}