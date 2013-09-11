using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace MvcApplication6.Models
{
    public class Player
    {

        public static Regex reYear = new Regex(
            "(\\d{4})",
                       RegexOptions.Multiline |
                       RegexOptions.CultureInvariant |
                       RegexOptions.Compiled);

        public static Regex reLastName = new Regex(
            "\\s(\\w+)\\s\\(",
                              RegexOptions.Multiline |
                              RegexOptions.CultureInvariant |
                              RegexOptions.Compiled);

        public static Regex reFirstName = new Regex(
            "^(.+)\\s\\w+\\s\\(\\d+",
                                     RegexOptions.Multiline |
                                     RegexOptions.CultureInvariant |
                                     RegexOptions.Compiled);

        public Player()
        {

        }

        public Player (string name)
        {
            this.Year = Convert.ToInt16(reYear.Match(name).Captures[0].Value);
            
            try
            {
                this.FirstName = reFirstName.Match(name).Captures[0].Value;
            } catch
            {
            }

            try
            {
                this.LastName = reLastName.Match(name).Captures[0].Value;
            } catch {}

        }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public short Year { get; set; }

        public DateTime BirthDate { get; set; }

    }

}