using eTickets.Data;
using eTickets.Data.Base;
using eTickets.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class NewMovieVM
{
    [Display(Description = "Movie Name")]
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }

    [Display(Description = "Movie Description")]
    [Required(ErrorMessage = "Description is required")]
    public string Description { get; set; }

    [Display(Description = "Price in $")]
    [Required(ErrorMessage = "Price is required")]
    public double Price { get; set; }

    [Display(Description = "Movie Poster URL")]
    [Required(ErrorMessage = "Movie Poster URL is required")]
    public string ImageURL { get; set; }

    [Display(Description = "Movie Start Date")]
    [Required(ErrorMessage = "Start Date is required")]
    public DateTime StartDate { get; set; }

    [Display(Description = "Movie End Date")]
    [Required(ErrorMessage = "End Date is required")]
    public DateTime EndDate { get; set; }

    [Display(Description = "Select a category")]
    [Required(ErrorMessage = "Movie category is required")]
    public MovieCategory MovieCategory { get; set; }

    [Display(Name = "Select actor(s)")]
    [Required(ErrorMessage = "Movie actor(s) is required")]
    public List<int> ActorIds { get; set; }

    [Display(Description = "Select a Cinema")]
    [Required(ErrorMessage = "Movie cinema is required")]
    public int CinemaId { get; set; }

    [Display(Description = "Select a Producer")]
    [Required(ErrorMessage = "Movie producer is required")]
    public int ProducerId { get; set; }
}

