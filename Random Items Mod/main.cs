
using UnityEngine;

namespace Mod
{
    public class Mod
    {
        
        public static void OnLoad()
        {
            UnityEngine.Debug.Log("Haha");
        }

        
        public static void Main()
        {

CategoryBuilder.Create("Random Items Mod", "All the Mod Items.", ModAPI.LoadSprite("VB.png"));

ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Knife"), //i
        NameOverride = "Nerf Knife -RIM", //n
        DescriptionOverride = "It is a cool ass Nerf Knife.", //n
        CategoryOverride = ModAPI.FindCategory("Random Items Mod"), //n
        ThumbnailOverride = ModAPI.LoadSprite("nerfknife.png"), //n
        AfterSpawn = (Instance) => //a
        {
            //g
            Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("NerfKnifet.png"); 
        }
    }
); 

ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Fusion Bomb"),
        NameOverride = "GigaChad Bomb",
        DescriptionOverride = "It does explode like gigachad xD",
        CategoryOverride = ModAPI.FindCategory("Random Items Mod"),
        ThumbnailOverride = ModAPI.LoadSprite("gigachadt.png"),
        AfterSpawn = (Instance) =>
        { 
            Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("gigachad.png");
            Instance.FixColliders();
            
        }  
    }
);


ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Knife"), //i
        NameOverride = "Bloody Knife -RIM", //n
        DescriptionOverride = "I think someone got murdered with it.", //n
        CategoryOverride = ModAPI.FindCategory("Random Items Mod"), //n
        ThumbnailOverride = ModAPI.LoadSprite("bloodyknifet.png"), //n
        AfterSpawn = (Instance) => //a
        {
            //g
            Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("bloodyknife.png"); 
            Instance.FixColliders();
        }
    }
); 

ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Metal Cube"), //i
        NameOverride = "Cursor -RIM", //n
        DescriptionOverride = "Its a cursor lol.", //n
        CategoryOverride = ModAPI.FindCategory("Random Items Mod"), //n
        ThumbnailOverride = ModAPI.LoadSprite("cursort.png"), //n
        AfterSpawn = (Instance) => //a
        {
            //g
            Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("cursor.png"); 
            Instance.FixColliders();
        }
    }
); 

ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Brick"), //i
        NameOverride = "Controller -RIM", //n
        DescriptionOverride = "Its a ps4 controller.", //n
        CategoryOverride = ModAPI.FindCategory("Random Items Mod"), //n
        ThumbnailOverride = ModAPI.LoadSprite("ps4ct.png"), //n
        AfterSpawn = (Instance) => //a
        {
            //g
            Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("ps4c.png"); 
            Instance.FixColliders();
        }
    }
); 

ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Brick"), //i
        NameOverride = "Robux -RIM", //n
        DescriptionOverride = "Get in the Van kids.", //n
        CategoryOverride = ModAPI.FindCategory("Random Items Mod"), //n
        ThumbnailOverride = ModAPI.LoadSprite("robuxt.png"), //n
        AfterSpawn = (Instance) => //a
        {
            //g
            Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("robux.png"); 
            Instance.FixColliders();
        }
    }
); 

ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Brick"), //i
        NameOverride = "Burger -RIM", //n
        DescriptionOverride = "Yummy.", //n
        CategoryOverride = ModAPI.FindCategory("Random Items Mod"), //n
        ThumbnailOverride = ModAPI.LoadSprite("burgert.png"), //n
        AfterSpawn = (Instance) => //a
        {
            //g
            Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("burger.png"); 
            Instance.FixColliders();
        }
    }
); 

ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Brick"), //i
        NameOverride = "Slipper -RIM", //n
        DescriptionOverride = "Slap some People.", //n
        CategoryOverride = ModAPI.FindCategory("Random Items Mod"), //n
        ThumbnailOverride = ModAPI.LoadSprite("slippert.png"), //n
        AfterSpawn = (Instance) => //a
        {
            //g
            Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("slipper.png"); 
            Instance.FixColliders();
        }
    }
); 

ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Dynamite"), //i
        NameOverride = "Explosive Cake -RIM", //n
        DescriptionOverride = "It explods.", //n
        CategoryOverride = ModAPI.FindCategory("Random Items Mod"), //n
        ThumbnailOverride = ModAPI.LoadSprite("explosivecaket.png"), //n
        AfterSpawn = (Instance) => //a
        {
            //g
            Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("explosivecake.png"); 
            Instance.FixColliders();
        }
    }
); 

ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Human"), //i
        NameOverride = "Civilian -RIM", //n
        DescriptionOverride = "Dont kill him he has a family.", //n
        CategoryOverride = ModAPI.FindCategory("Random Items Mod"), //n
        ThumbnailOverride = ModAPI.LoadSprite("Civiliant.png"), //n
        AfterSpawn = (Instance) => //a
        {
            //l
            var skin = ModAPI.LoadTexture("Civilian.png");
            var flesh = ModAPI.LoadTexture("flesh.png");
            var bone = ModAPI.LoadTexture("bone.png");

            //g
            var person = Instance.GetComponent<PersonBehaviour>();

            //u
            //p 
            //  s
            //y
            person.SetBodyTextures(skin, flesh, bone, 1);

            //c
            person.SetBruiseColor(86, 62, 130); //m
            person.SetSecondBruiseColor(154, 0, 7); //s
            person.SetThirdBruiseColor(207, 206, 120); // t
            person.SetRottenColour(202, 199, 104); // r
            person.SetBloodColour(108, 0, 4); // b
        }
    }
);


ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Human"), //i
        NameOverride = "Business -RIM", //n
        DescriptionOverride = "He does his taxes.", //n
        CategoryOverride = ModAPI.FindCategory("Random Items Mod"), //n
        ThumbnailOverride = ModAPI.LoadSprite("Businesst.png"), //n
        AfterSpawn = (Instance) => //a
        {
            //l
            var skin = ModAPI.LoadTexture("Business.png");
            var flesh = ModAPI.LoadTexture("flesh.png");
            var bone = ModAPI.LoadTexture("bone.png");

            //g
            var person = Instance.GetComponent<PersonBehaviour>();

            //u
            //p 
            //  s
            //y
            person.SetBodyTextures(skin, flesh, bone, 1);

            //c
            person.SetBruiseColor(86, 62, 130); //m
            person.SetSecondBruiseColor(154, 0, 7); //s
            person.SetThirdBruiseColor(207, 206, 120); // t
            person.SetRottenColour(202, 199, 104); // r
            person.SetBloodColour(108, 0, 4); // b
        }
    }
);

ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Crossbow Bolt"), //i
        NameOverride = "Nail -RIM", //n
        DescriptionOverride = "Its a nail, wow.", //n
        CategoryOverride = ModAPI.FindCategory("Random Items Mod"), //n
        ThumbnailOverride = ModAPI.LoadSprite("nagelt.png"), //n
        AfterSpawn = (Instance) => //a
        {
            //g
            Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("nagel.png"); 
            Instance.FixColliders();
        }
    }
);  
  
ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Crossbow Bolt"), //i
        NameOverride = "Pencil -RIM", //n
        DescriptionOverride = "Watch out for the Eye.", //n
        CategoryOverride = ModAPI.FindCategory("Random Items Mod"), //n
        ThumbnailOverride = ModAPI.LoadSprite("pencilt.png"), //n
        AfterSpawn = (Instance) => //a
        {
            //g
            Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("pencil.png"); 
            Instance.FixColliders();
        }
    }
);  
  
ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Brick"), //i
        NameOverride = "Ruler -RIM", //n
        DescriptionOverride = "You can use them for some sus stuff.", //n
        CategoryOverride = ModAPI.FindCategory("Random Items Mod"), //n
        ThumbnailOverride = ModAPI.LoadSprite("rulert.png"), //n
        AfterSpawn = (Instance) => //a
        {
            //g
            Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("ruler.png"); 
            Instance.FixColliders();
        }
    }
);    

ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Brick"), //i
        NameOverride = "Rubber -RIM", //n
        DescriptionOverride = "You can erase pencils.", //n
        CategoryOverride = ModAPI.FindCategory("Random Items Mod"), //n
        ThumbnailOverride = ModAPI.LoadSprite("rubbert.png"), //n
        AfterSpawn = (Instance) => //a
        {
            //g
            Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("rubber.png"); 
            Instance.FixColliders();
        }
    }
);    
  
  
        }
    }
}