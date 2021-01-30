using GameDemo.Entities;
using GameDemo.Interfaces;
using MernisValidationService;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.ManageServives
{
    class GamerManagerServices : IGamerService 
    {

        IGamerValidationService _gamerValidationService;

        public GamerManagerServices(IGamerValidationService gamerValidationService) //ctor içerisine doğrulama servisini enjekte ettim.
        {                                                                          //bu sayede gamermanagerservice newlendiğinde parametre olarak bir doğrulama servisi isteyecek. Şimdilik sadece mernis var.
            this._gamerValidationService = gamerValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerValidationService.CheckValidation(gamer) == true)
            {
                Console.WriteLine(gamer.GamerFirstName + " " + gamer.GamerLastName + " isimli oyuncu" + " " + gamer.GamerId + " numarası ile sisteme kayıt edildi.");
            }
            else
            {
                Console.WriteLine("Kimlik doğrulama başarısız!");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerFirstName + " " + gamer.GamerLastName + " isimli oyuncu sistemden silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerId + " numaralı oyuncunun bilgileri güncellendi.");
        }
    }
}