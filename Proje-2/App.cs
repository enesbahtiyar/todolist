using System;
using System.Collections.Generic;

namespace _22_ToDoListUygulamasi
{
    public class App
    {
        private Dictionary<int, string> personalList = new Dictionary<int, string>();
        private List<Card> cardList = new List<Card>(); 

        public App()
        {
            FirstStart();
        }
        public void Run()
        {
            string select = Menu();
            switch(select)
            {
                case "1" :
                {
                    if (ShowBoard.showBoard(cardList, personalList) == isComplate.Yes)    
                        Console.WriteLine("Tüm line'lar başarıyla gösterildi.");
                    else    
                        Console.WriteLine("Line'lar oluşturulurken hata oluştu");
                }break;
                case "2" :
                {
                    if (AddCard.addCard(cardList, personalList) == isComplate.Yes)   
                        Console.WriteLine("Yeni kart başarıyla eklendi.");
                    else    
                        Console.WriteLine("Yeni kart kaydedilirken bir hata oluştu.!");
                }break;
                case "3" :
                {
                    if (DeleteCard.deleteCard(cardList) == isComplate.Yes)   
                        Console.WriteLine("Eşleşen tüm kartlar başarıyla silindi.");
                    else    
                        Console.WriteLine("Kart silme esnasında bir hatayla karşılaşıldı.");
                }break;
                case "4" :
                {
                    if (TransformCard.transformCard(cardList, personalList) == isComplate.Yes)   
                        Console.WriteLine("Kart başarıyla istenen line'a taşındı.");
                    else    
                        Console.WriteLine("Kart istenen line'a taşınırken bir hata ile karşılaşıldı.!");
                }break;
                default : Console.WriteLine("\nHatalı bir seçim yaptınız!.\n"); break;
            }
        }
        private string Menu()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)\n" + 
                            "*******************************************\n" +
                            "(1) Board Listelemek\n" +
                            "(2) Board'a Kart Eklemek\n" +
                            "(3) Board'dan Kart Silmek\n" +
                            "(4) Kart Taşımak");
            return Console.ReadLine();
        }
        public void FirstStart()
        {
            Card newCard = new Card();
            newCard.BoardID = 0;
            newCard.CardID = 1;
            newCard.Title = "Deneme";
            newCard.Description = "Bu deneme kartıdır";
            newCard.Size = CardSize.XS;
            newCard.personalAdd(111);
            cardList.Add(newCard);
            personalList pl = new personalList();
            for (int i = 0; i < pl.perID.Length; i++)
            {
                personalList.Add(pl.perID[i], pl.perName[i]);
            }
        }
    }
}