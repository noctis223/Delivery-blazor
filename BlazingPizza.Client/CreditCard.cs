using System.ComponentModel.DataAnnotations;

public  class CreditCard
{
    [Required, MaxLength(100)]
    public string OwnerName { get; set; }= String.Empty;
    [Required, MaxLength(100)]
    public string CardNumber { get; set; }=String.Empty;
    [Required, MaxLength(100)]
    public string ExpirationDate { get; set; }=String.Empty;
    [Required, MaxLength(100)]
    public string CVC { get; set; }=String.Empty;
}   

