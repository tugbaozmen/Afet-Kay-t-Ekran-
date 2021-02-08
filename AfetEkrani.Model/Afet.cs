using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfetEkrani.Model
{
    public class Afet:BaseEntity
    {
        public Afet()
        {
            AdresDetaylari = new HashSet<AdresDetay>();
        }
        public int AfetId { get; set; }
        public int AfetTuruId { get; set; }
        [Required(ErrorMessage = "Seri No boş geçilemez")]
        public string SeriNo { get; set; }
        [Required(ErrorMessage = "Glide No boş geçilemez")]
        public string GlideNo { get; set; }
        [Required(ErrorMessage = "Neden alanı boş geçilemez")]
        public string Neden { get; set; }
        [Required(ErrorMessage = "Açıklama alanı boş geçilemez")]
        public string Aciklama { get; set; }
        [Required(ErrorMessage = "Etkilediği alanlar kısmı boş geçilemez")]
        public string EtkiledigiAlanlar { get; set; }
        [Required(ErrorMessage = "Kaynak boş geçilemez")]
        public string Kaynak { get; set; }
        [Required(ErrorMessage = "Lütfen başlangıç tarihi seçiniz")]

        [DataType(DataType.DateTime)]
        public DateTime BaslangicTarihi { get; set; }

        [Required(ErrorMessage = "Lütfen bitiş tarihi seçiniz")]
        [DataType(DataType.DateTime)]
        public DateTime BitisTarihi { get; set; }
        public string Sure { get; set; }
        [Required(ErrorMessage = "Enlem alanı boş geçilemez")]
        public float Enlem { get; set; }
        [Required(ErrorMessage = "Boylam alanı boş geçilemez")]
        public float Boylam { get; set; }
        [Required(ErrorMessage = "Dosya açıklaması boş geçilemez")]
        public string DosyaAciklama { get; set; }
        [Required(ErrorMessage = "Lütfen dosya seçiniz")]
        public string DosyaYolu { get; set; }
        [Required(ErrorMessage = "Lütfen onay durumu seçiniz")]
        public OnayDurum OnayDurum { get; set; }

        //Navigation Property
        public AfetTuru AfetTuru { get; set; }
        public ICollection<AdresDetay> AdresDetaylari { get; set; }
    }

    public enum OnayDurum
    {
        OnayBekliyor = 1,
        Onaylandı = 2,
        Reddedildi = 3,
        Yayında = 4
    }
}
