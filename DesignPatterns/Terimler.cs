using System;

/// <summary>
/// "Terimler " adında açılmış bir class..
/// </summary>
public class Terimler {



    //#####  public, private, protected, internal gibi terimler "Modifier" veya "Access Modifiers" diye çağrılırlar.  Türkçesi "Erişim Belirleyiciler"
    /*
    "Private"  : Sadece kendi kod bloğu içerisinden çağrılabilir. 
    "Public"   : Hem kendi kod bloğu üzerinden hem de dışarıdan hatta farklı projeler üzerinden de çağırılabilir.
    "Internal" : Kendi projesi içerisinde erişilebilir ancak farklı bir projeden erişilemez.Aksi belirtilmedikçe bütün classlar default olarak "Interval"dir. 
    "Protected": Sadece bulunduğu class üzerinde ve bu class'ı miras alan (derived yani bu class'tan türetilmiş) classlardan erişilebilir.
    "Proteced Internal" : Bir nesne protected internal olarak tanımlandığında aynı protected gibi kendi bulunduğu class üzerinde ve bu class ı miras alan classlar üzerinden çağrılabilir. Artı olarak aynı proje (assembly/dll) üzerinde olmasalar dahi, tanımlandığı class’tan türetilmiş diğer class’ların içinden de çağırılabilirler.
    */
    
        
    //#####           Aşağıdakilerin hepsi bu "Terimler" class'ının üyesi yani "MEMBER" diye bilinir.

    /// <summary>
    /// FIELD
    /// </summary>
    public string mesaj;
    /// <summary>
    /// FIELD
    /// </summary>
    public int id;
    /// <summary>
    /// FIELD
    /// </summary>
    public string color;

    /// <summary>
    //              Bur bir METHOD.
    //              'Constructor Method' yani oluşturucu method.
    //              "ctor" yazıp tab tuşuyla desteklersek otomatik oluşturulur. Ya da aşağıdaki gibi elle yazılır.
    //              "Terimler"  CLASS'ımız çağrıldığında, ilk önce bu method çalıştırılır (bir yerlerden çaprılmasa bile!).
    /// </summary>
    public Terimler()
    {

    }

    /// <summary>
    ///             METHOD (private açılmış bir method)
    /// </summary>
    private void Method1()      
    {

    }
}
