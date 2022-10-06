using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EtecShop.Models;
[Table("Product")]
public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    public int Id { get; set; }

    [Display(Name = "Nome do Produto")]
    [Required(ErrorMessage = "Por favor, informe o Nome do Produto")]
    [StringLength(200, ErrorMessage = "O Nome deve possuir no maximo 200 caracteres")]

    public string Name { get; set; }

    [Display(Name = "Descrição")]
    [StringLength(8000, ErrorMessage = "A descrição deve possuir no maximo 8000 caracteres")]

    public string Description { get; set; }

    
    [Display(Name = "Preço")]
    [Column(TypeName = "decimal(10,2)")]
    [Required(ErrorMessage = "Por favor, informe o preçp do Produto")]
    [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
    public decimal Price { get; set; }

    
    [Display(Name = "Imagem")]
    [StringLength(200)]
    public string Image { get; set; }

    [Display(Name = "Categoria")]
    [Required(ErrorMessage = "Por favor, informe a categoria do Produto")]
    public int CategoryId { get; set; }
    [ForeignKey("CategoryId")]

    public Category Category { get; set; }

    [Display(Name = "Marca")]
    [Required(ErrorMessage = "Por favor, informe a Marca do Produto")]
    public int BrandId { get; set; }
    [ForeignKey("BrandId")]

    public Brand Brand { get; set; }




}
