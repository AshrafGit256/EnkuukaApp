namespace EnkuukaApp.Models;

public class Masaza
{
    public string Name { get; set; } = "";
    public string Chief { get; set; } = "";
    public string Img { get; set; } = "";
    public string Area { get; set; } = "";
    public string Desc { get; set; } = "";
    public string Known { get; set; } = "";
}

public class Clan
{
    public string Name { get; set; } = "";
    public string Totem { get; set; } = "";
    public string Head { get; set; } = "";
    public bool IsOriginal { get; set; }
    public bool IsRoyal { get; set; }
    public string Img { get; set; } = "";
}

public class EventItem
{
    public string Time { get; set; } = "";
    public string Title { get; set; } = "";
    public string Desc { get; set; } = "";
}

public class Hotel
{
    public string Name { get; set; } = "";
    public string Location { get; set; } = "";
    public string Price { get; set; } = "";
    public string Stars { get; set; } = "";
    public string Img { get; set; } = "";
}

public static class SiteData
{
    public static readonly List<Masaza> Masaza = new()
    {
        new() { Name="Kyaddondo", Chief="Ssabaganzi", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Kampala_Kyadondo.jpg", Area="Kampala & Metro", Desc="Home to Kampala. One of the four original Buganda counties — the royal heartland where Lubiri Palace stands. Seat of political and cultural power.", Known="Lubiri Palace · Kampala City" },
        new() { Name="Busiro", Chief="Mugema", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/MengoPalace_Busiro.jpg", Area="Central", Desc="Ancient heartland of Buganda containing the UNESCO Kasubi Royal Tombs. Burial grounds of Buganda kings.", Known="Kasubi Royal Tombs · Naggalabi" },
        new() { Name="Kyaggwe", Chief="Kago", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/SsezibwaFalls_Kyagwe1.jpg", Area="Eastern", Desc="Eastern county rich in fertile land and cultural heritage, home to iconic natural sites.", Known="Sezibwa Falls · Mukono" },
        new() { Name="Buddu", Chief="Pokino", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/KitovuCathedral_Buddu.png", Area="Southern", Desc="Fertile agricultural region known for bananas and coffee production.", Known="Masaka · Katonga River" },
        new() { Name="Ssingo", Chief="Kasujju", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/MityanaTeaEstate_Ssingo.png", Area="Northern", Desc="Largest Buganda county with strong agricultural presence and tea growing.", Known="Mityana · Tea Estates" },
        new() { Name="Mawokota", Chief="Kangawo", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Equator_Mawokota.jpg", Area="Central-West", Desc="Known for the Uganda Equator landmark and lakeside communities.", Known="Mpigi · Equator Monument" },
        new() { Name="Busujju", Chief="Kitunzi", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/BwindiForest_Busujju2.jpg", Area="Western", Desc="Traditional Buganda countryside with deep cultural roots.", Known="Mityana region" },
        new() { Name="Bulemeezi", Chief="Kimbugwe", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Pineapple_Bulemeezi.png", Area="Northwest", Desc="Known for pineapple farming and mixed agriculture.", Known="Zirobwe · Luweero" },
        new() { Name="Buluuli", Chief="Kimbugwe", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Grazing_Buluuli1.jpg", Area="North", Desc="Savannah grasslands with pastoral farming and cattle keeping.", Known="Nakasongola · Lake Kyoga" },
        new() { Name="Bugerere", Chief="Mugema wa Bugerere", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/SugarcaneFields_Bugerere.png", Area="Northeast", Desc="Major sugarcane growing region and agricultural hub.", Known="Kayunga · Sugar plantations" },
        new() { Name="Gomba", Chief="Kasujju wa Gomba", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Grazing_Gomba.jpg", Area="Southwest", Desc="Pastoral county known for long-horned cattle and ranching.", Known="Kabulasoke · Ranches" },
        new() { Name="Butambala", Chief="Namasole", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Ginger_Butambala.png", Area="Central", Desc="Culturally rich rural county with traditional homesteads.", Known="Gombe · Bulo" },
        new() { Name="Buwekula", Chief="Katambala", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/NakayimaTree_Buwekula.jpg", Area="Northwest", Desc="Home to sacred traditional sites and rolling hills.", Known="Nakayima Tree · Mubende" },
        new() { Name="Kabula", Chief="Mukwenda", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Grazing_Kabula.jpg", Area="Southern", Desc="Coffee-growing region with strong agricultural identity.", Known="Lyantonde · Rakai" },
        new() { Name="Kooki", Chief="Ssabaganzi wa Kooki", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Boarder_Kooki.png", Area="Southwest", Desc="Semi-arid region with cattle keeping and unique sub-kingdom identity.", Known="Rakai · Border region" },
        new() { Name="Mawogola", Chief="Kangawo wa Mawogola", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Grazing_Mawogola.jpg", Area="South", Desc="Cattle corridor region with expansive grazing land.", Known="Sembabule" },
        new() { Name="Ssese", Chief="Gabunga", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Beach_Ssese.jpg", Area="Lake Victoria", Desc="Island county with palm beaches and strong spiritual heritage.", Known="Bugala Island · Ssese Islands" },
        new() { Name="Buvuma", Chief="Mugema wa Buvuma", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Fishing_Buvuma.png", Area="Lake Victoria", Desc="Island district known for fishing communities.", Known="Buvuma Island · Lake Victoria" },
    };

    public static readonly List<Clan> Clans = new()
    {
        new() { Name="Ffumbe", Totem="African Civet", Head="Walusimbi", IsOriginal=true, Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/civet.png" },
        new() { Name="Lugave", Totem="Pangolin", Head="Ndugwa", IsOriginal=true, Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/pangolin.jpg" },
        new() { Name="Ngonge", Totem="Otter", Head="Nakigoye Kisolo", IsOriginal=true, Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/otter.jpg" },
        new() { Name="Njaza", Totem="Reedbuck", Head="Kitanda", IsOriginal=true, Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/ReedBuck.jpg" },
        new() { Name="Abalangira", Totem="Royal — no totem", Head="Ssaabataka (Kabaka)", IsRoyal=true, Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Royals.jpg" },
        new() { Name="Mmamba Gabunga", Totem="Lungfish", Head="Gabunga", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/LungFish.jpg" },
        new() { Name="Mmamba Kakoboza", Totem="Lungfish", Head="Nankere", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/LungFish.jpg" },
        new() { Name="Ngo", Totem="Leopard", Head="Muteesasira", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Leopard.jpg" },
        new() { Name="Ngabi Nnyunga", Totem="Bushbuck", Head="Kannyana", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/BushBuck.jpg" },
        new() { Name="Ngabi Nsamba", Totem="Bushbuck", Head="Nsamba", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/BushBuck.jpg" },
        new() { Name="Ngaali", Totem="Crested Crane", Head="Mawesano", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/CrestedCrane.jpg" },
        new() { Name="Ngeye", Totem="Colobus Monkey", Head="Kasujja", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/ColobusMonkey.jpg" },
        new() { Name="Nkejje", Totem="Sprat Fish", Head="Kikwata", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/SpratFish2.jpg" },
        new() { Name="Njovu", Totem="Elephant", Head="Mukalo", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/elephant.jpg" },
        new() { Name="Nkima", Totem="Monkey", Head="Mugema", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/monkey.jpg" },
        new() { Name="Mpeewo", Totem="Oribi Antelope", Head="Kiggye", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Antelope.jpg" },
        new() { Name="Mbogo", Totem="Buffalo", Head="Kayiira Gajule", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Buffalo.jpg" },
        new() { Name="Mbwa", Totem="Dog", Head="Mutasingwa", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Dog.jpg" },
        new() { Name="Nte", Totem="Cow", Head="Katongole Muggatta", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/cow.jpg" },
        new() { Name="Musu", Totem="Cane Rat", Head="Muyingo", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/CaneRat2.png" },
        new() { Name="Mutima Musagi", Totem="Heart", Head="Nakirembeka", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Heart1.png" },
        new() { Name="Mutima Omuyanja", Totem="Heart", Head="Namugera Kakeeto", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Heart1.png" },
        new() { Name="Kkobe", Totem="Creeping Plant", Head="Nnamwama", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Kkobe.jpg" },
        new() { Name="Kasimba", Totem="Genet Cat", Head="Kabazzi", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/GenetCat.jpg" },
        new() { Name="Kayozi", Totem="Jerboa", Head="Kafumu", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Jerboa.jpg" },
        new() { Name="Nseenene", Totem="Grasshopper", Head="Kalibbala", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/GrassHoper.avif" },
        new() { Name="Ntalaganya", Totem="Blue Duiker", Head="Bbambaga", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Duiker.jpg" },
        new() { Name="Ndiisa", Totem="Lark", Head="Kaliika", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/LarkBird.jpg" },
        new() { Name="Mpologoma", Totem="Lion", Head="Ssebuganda Namuguzi", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Lion3.jpg" },
        new() { Name="Butiko", Totem="Fungus", Head="Ggunju", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Mushroom3.png" },
        new() { Name="Mpindi", Totem="Black-eyed Pea", Head="Mazige", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Mpindi.png" },
        new() { Name="Nvuma", Totem="Water plant", Head="Kyaddondo", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Nvuma1.png" },
        new() { Name="Nkula", Totem="Red Ochre", Head="Muwangi", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Rhinocerous.jpg" },
        new() { Name="Nkerebwe", Totem="Squirrel", Head="Kidimbo", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Squirrel.jpg" },
        new() { Name="Ndiga", Totem="Sheep", Head="Lwomwa", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Sheep1.png" },
        new() { Name="Mazzi ga Kisasi", Totem="Water Droplets", Head="Wooyo", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/RainWater.png" },
        new() { Name="Nkebuka", Totem="(Historical)", Head="Kayizzi", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Nkebuka.png" },
        new() { Name="Lukato", Totem="(Historical)", Head="Magunda", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/LukatoClan.jpg" },
        new() { Name="Mbuzi", Totem="Goat", Head="Kisunsu", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Goat.jpg" },
        new() { Name="Nvubu", Totem="Hippo", Head="Kayita", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Hippo.jpg" },
        new() { Name="Nsuma", Totem="Snout Fish", Head="Kibondwe", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Nsuma3.png" },
        new() { Name="Nswaswa", Totem="Nile monitor lizard", Head="Mayengo", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Lizard2.jpg" },
        new() { Name="Nnyonyi Nnyange", Totem="Heron Bird", Head="Mbaziira", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/HeronBird2.jpg" },
        new() { Name="Kiwere", Totem="Duiker", Head="Luwonko", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Kiwere.png" },
        new() { Name="Babiito-Kooki", Totem="Drum", Head="Ssababiito", IsRoyal=true, Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Entenga.jpg" },
        new() { Name="Babiito-Kiziba", Totem="Drum", Head="Lutayinzibwato", IsRoyal=true, Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Entenga.jpg" },
        new() { Name="Kibe", Totem="Fox", Head="Muyige", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/fox3.jpg" },
        new() { Name="Kinyomo", Totem="Large Black Ant", Head="Nakigoye", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/BlackAnt2.png" },
        new() { Name="Nakinsige", Totem="Oriole Bird", Head="Kyeyune", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/OrioleBird.jpg" },
        new() { Name="Namunggona", Totem="Crow", Head="Kajjabwongwa", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Crow.jpg" },
        new() { Name="Nsunu", Totem="Uganda Kob", Head="Kibugaya", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Kob1.jpg" },
        new() { Name="Kasanke", Totem="African Firefinch", Head="Kyangu", Img="https://raw.githubusercontent.com/AshrafGit256/enkuuka-site/main/public/assets/images/Kasanke.jpg" },
    };

    public static readonly List<EventItem> Programme = new()
    {
        new() { Time="8:00AM", Title="Helicopter Arrival", Desc="Royal Helicopter lands. Kabaka makes his grand aerial entry." },
        new() { Time="9:00AM", Title="Gates Open", Desc="Trade fair and service tents begin at Lubiri Palace." },
        new() { Time="9:30AM", Title="Key Ceremony", Desc="Okunoonya Engule — symbolic clan key-searching ritual." },
        new() { Time="10:00AM", Title="Business Exhibition", Desc="200+ SME and corporate exhibitors officially open." },
        new() { Time="12:00PM", Title="Cultural Performances", Desc="Royal drumming, Baakisimba dance and traditional showcases." },
        new() { Time="2:00PM", Title="Kabaka's Address", Desc="His Majesty the Kabaka addresses the kingdom." },
        new() { Time="3:30PM", Title="Clan Championships", Desc="Inter-clan cultural competition — dress, dance, storytelling." },
        new() { Time="5:00PM", Title="Sunset Concert", Desc="Supporting artists warm up the crowd as the sun sets." },
        new() { Time="7:00PM", Title="Headline Performances", Desc="Top Ugandan artists on the main stage." },
        new() { Time="9:30PM", Title="Royal Bonfire", Desc="Omuliro Gw'Omwaka — sacred year-fire ceremony with elders." },
        new() { Time="11:00PM", Title="Pre-Countdown Show", Desc="Final DJ set and crowd preparation for the New Year." },
        new() { Time="12:00AM", Title="New Year Fireworks!", Desc="Fireworks explode above Lubiri Palace. Happy New Year!" },
    };

    public static readonly List<Hotel> Hotels = new()
    {
        new() { Name="Kampala Serena Hotel", Location="Kintu Road", Price="UGX 380,000/night", Stars="★★★★★", Img="https://images.unsplash.com/photo-1566073771259-6a8506099945?w=700&q=80" },
        new() { Name="Sheraton Kampala", Location="Ternan Ave", Price="UGX 290,000/night", Stars="★★★★★", Img="https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=700&q=80" },
        new() { Name="Pearl of Africa Hotel", Location="Nakasero", Price="UGX 240,000/night", Stars="★★★★", Img="https://images.unsplash.com/photo-1542314831-068cd1dbfeeb?w=700&q=80" },
        new() { Name="Protea Hotel Kampala", Location="Wampewo Ave", Price="UGX 160,000/night", Stars="★★★★", Img="https://images.unsplash.com/photo-1566073771259-6a8506099945?w=700&q=80" },
        new() { Name="Emin Pasha Hotel", Location="Akii-Bua Road", Price="UGX 140,000/night", Stars="★★★", Img="https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=700&q=80" },
        new() { Name="Mengo Palace Guest", Location="Mengo", Price="UGX 85,000/night", Stars="★★★", Img="https://images.unsplash.com/photo-1542314831-068cd1dbfeeb?w=700&q=80" },
    };
}
