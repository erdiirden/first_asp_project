//using deneme.Models.ModelMetaDataTypes;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace deneme.Models
{
    //[ModelMetadataType(typeof(ProductMetaData))]
    public class Product
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Email { get; set; }
    }
}
