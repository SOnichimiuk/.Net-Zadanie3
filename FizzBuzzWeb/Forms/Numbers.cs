using System;
using System.ComponentModel.DataAnnotations;

namespace FizzBuzzWeb.Forms
{
    public class Numbers
    {
        [Display(Name = "Liczba:")]
        [Required(ErrorMessage = "Podaj liczbę!")]
        [Range(1, 1000, ErrorMessage = "Podaj liczbę z zakresu 1-1000!")]
        public int Number { get; set; }

        public string Date { get; set; }

        public string Message { get; set; }
    }
}