using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SwaggerWebAppDemo.Models
{
    /// <summary>
    /// Model class for submitting search requests into the API methods
    /// </summary>
    public class SearchRequestModel
    {
        /// <summary>
        /// The search critera that should be used.  
        /// </summary>
        /// <remarks>
        /// Can use * or _ for wildcards (Note, not shown)
        /// </remarks>
        /// <value>User desired search (Note, not shown)</value>
        [Required]
        public string SearchCriteria { get; set; }

        /// <summary>
        /// Should the search include deleted records.
        /// </summary>
        public bool IncludeDeleted { get; set; }
    }

    /// <summary>
    /// Represents a response to employer search methods
    /// </summary>
    public class EmployerSearchResultModel
    {
        /// <summary>
        /// Was this successful
        /// </summary>
        public bool Successful { get; set; }

        /// <summary>
        /// The listing of found employers
        /// </summary>
        public List<Employer> Employers { get; set; }
    }

    public class Employer
    {
        /// <summary>
        /// First name of the employer
        /// </summary>
        public string FirstName { get; set; }
    }
}