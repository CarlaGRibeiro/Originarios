
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Originarios.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Usuario
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Usuario()
    {

        this.Postagem = new HashSet<Postagem>();

        this.Publicacao = new HashSet<Publicacao>();

    }


    public int id_usu { get; set; }

    public string nome { get; set; }

    public System.DateTime dt_nasc { get; set; }

    public string email { get; set; }

    public string cpf { get; set; }

    public string cidade { get; set; }

    public string estado { get; set; }

    public string ddd { get; set; }

    public string whatsapp { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Postagem> Postagem { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Publicacao> Publicacao { get; set; }

}

}