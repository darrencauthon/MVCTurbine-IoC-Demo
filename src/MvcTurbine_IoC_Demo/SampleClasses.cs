namespace MvcTurbine_IoC_Demo
{
    public interface IPepe
    {
    }

    public class Pepe : IPepe
    {
        public Pepe(IHam ham, IProvolone provolone, ILettuce lettuce, ITomato tomato, IMayo mayo)
        {
        }
    }

    public interface IBigJohn
    {
    }

    public class BigJohn : IBigJohn
    {
        public BigJohn(IRoastBeef roastBeef, IMayo mayo, ILettuce lettuce, ITomato tomato)
        {
        }
    }

    public interface ITotallyTuna
    {
    }

    public class TotallyTuna : ITotallyTuna
    {
        public TotallyTuna(ITuna tuna, ICelery celery, IOnion onion, ITomato tomato, IAlfalfa alfalfa, ICucumber cucumber, ILettuce lettuce)
        {
        }
    }

    public interface ITurkeyTom
    {
    }

    public class TurkeyTom : ITurkeyTom
    {
        public TurkeyTom(ITurkey turkey, ILettuce lettuce, ITomato tomato, IVinaigrette vinaigrette)
        {
        }
    }

    public interface IVito
    {
    }

    public class Vito : IVito
    {
        public Vito(ISalami salami, IProvolone provolone, ICapicola capicola, IOnion onion, ILettuce lettuce, ITomato tomato, IVinaigrette vinaigrette)
        {
        }
    }

    public interface IVegetarian
    {
    }

    public class Vegetarian : IVegetarian
    {
        public Vegetarian(IProvolone provolone, IAvocado avocado, IAlfalfa alfalfa, ICucumber cucumber, ILettuce lettuce, ITomato tomato, IMayo mayo)
        {
        }
    }

    public interface IJjblt
    {
    }

    public class Jjblt : IJjblt
    {
        public Jjblt(IBacon bacon, ILettuce lettuce, ITomato tomato, IMayo mayo)
        {
        }
    }

    public interface IBacon
    {
    }

    public class Bacon : IBacon
    {
        public Bacon(IPig pig, IFarmer farmer)
        {
        }
    }

    public interface IFarmer
    {
    }

    public class Farmer : IFarmer
    {
        public Farmer(IMommy mommy, IDaddy daddy, IFarm farm)
        {
        }
    }

    public interface IFarm
    {
    }

    public class Farm : IFarm
    {
        public Farm(ILand land, IGovernmentSubsidy governmentSubsidy)
        {
        }
    }

    public interface ILand
    {
    }

    public class Land : ILand
    {
        public Land(IDirt dirt, IDeed deed)
        {
        }
    }

    public interface IDeed
    {
    }

    public class Deed : IDeed
    {
        public Deed(ILawyer lawyer)
        {
        }
    }

    public interface ILawyer
    {
    }

    public class Lawyer : ILawyer
    {
        public Lawyer(ILawSchool lawSchool)
        {
        }
    }

    public interface ILawSchool
    {
    }

    public class LawSchool : ILawSchool
    {
    }

    public interface IDirt
    {
    }

    public class Dirt : IDirt
    {
    }

    public interface IGovernmentSubsidy
    {
    }

    public class GovernmentSubsidy : IGovernmentSubsidy
    {
        public GovernmentSubsidy(ILobbyist lobbyist)
        {
        }
    }

    public interface ILobbyist
    {
    }

    public class Lobbyist : ILobbyist
    {
        public Lobbyist(IDaddy daddy, IMommy mommy)
        {
        }
    }

    public interface IDaddy
    {
    }

    public class Daddy : IDaddy
    {
    }

    public interface IMommy
    {
    }

    public class Mommy : IMommy
    {
    }

    public interface IPig
    {
    }

    public class Pig : IPig
    {
    }

    public interface IAvocado
    {
    }

    public class Avocado : IAvocado
    {
    }

    public interface ICapicola
    {
    }

    public class Capicola : ICapicola
    {
    }

    public interface ISalami
    {
    }

    public class Salami : ISalami
    {
        public Salami(IPig pig, ICow cow, IButcher butcher)
        {
        }
    }

    public interface IButcher
    {
    }

    public class Butcher : IButcher
    {
        public Butcher(IMommy mommy, IDaddy daddy)
        {
        }
    }

    public interface ICow
    {
    }

    public class Cow : ICow
    {
        public Cow(IGrass grass)
        {
        }
    }

    public interface IGrass
    {
    }

    public class Grass : IGrass
    {
    }

    public interface IVinaigrette
    {
    }

    public class Vinaigrette : IVinaigrette
    {
    }

    public interface ITurkey
    {
    }

    public class Turkey : ITurkey
    {
        public Turkey(IHunter hunter)
        {
        }
    }

    public interface IHunter
    {
    }

    public class Hunter : IHunter
    {
        public Hunter(IMommy mommy, IDaddy daddy, IKillerInstinct killerInstinct)
        {
        }
    }

    public interface IKillerInstinct
    {
    }

    public class KillerInstinct : IKillerInstinct
    {
    }

    public interface IAlfalfa
    {
    }

    public class Alfalfa : IAlfalfa
    {
        public Alfalfa(IDirt dirt, IFarmer farmer, ILittleRascalsJoke littleRascalsJoke)
        {
        }
    }

    public interface ILittleRascalsJoke
    {
    }

    public class LittleRascalsJoke : ILittleRascalsJoke
    {
        public LittleRascalsJoke(IWriter writer)
        {
        }
    }

    public interface IWriter
    {
    }

    public class Writer : IWriter
    {
        public Writer(IMommy mommy, IDaddy daddy)
        {
        }
    }

    public interface IOnion
    {
    }

    public class Onion : IOnion
    {
        public Onion(IDirt dirt, IFarmer farmer)
        {
        }
    }

    public interface ICelery
    {
    }

    public class Celery : ICelery
    {
        public Celery(IDirt dirt, IFarmer farmer)
        {
        }
    }

    public interface ITuna
    {
    }

    public class Tuna : ITuna
    {
        public Tuna(Fish fish, IFisherman fisherman, IBoat boat)
        {
        }
    }

    public interface IFisherman
    {
    }

    public class Fisherman : IFisherman
    {
        public Fisherman(IMommy mommy, IDaddy daddy)
        {
        }
    }

    public interface IFish
    {
    }

    public class Fish : IFish
    {
    }

    public interface IBoat
    {
    }

    public class Boat : IBoat
    {
        public Boat(IWood wood, ISteel steel)
        {
        }
    }

    public interface ISteel
    {
    }

    public class Steel : ISteel
    {
    }

    public interface IWood
    {
    }

    public class Wood : IWood
    {
        public Wood(ITree tree)
        {
        }
    }

    public interface ITree
    {
    }

    public class Tree : ITree
    {
    }

    public interface ICucumber
    {
    }

    public class Cucumber : ICucumber
    {
        public Cucumber(IFarmer farmer, IDirt dirt)
        {
        }
    }

    public interface IRoastBeef
    {
    }

    public class RoastBeef : IRoastBeef
    {
        public RoastBeef(IButcher butcher, ICow cow)
        {
        }
    }

    public interface IMayo
    {
    }

    public class Mayo : IMayo
    {
        public Mayo(IMilk milk, IQuestionableStuff questionableStuff)
        {
        }
    }

    public interface IQuestionableStuff
    {
    }

    public class QuestionableStuff : IQuestionableStuff
    {
    }

    public interface ITomato
    {
    }

    public class Tomato : ITomato
    {
        public Tomato(IDirt dirt, IFarmer farmer)
        {
        }
    }

    public interface ILettuce
    {
    }

    public class Lettuce : ILettuce
    {
        public Lettuce(IDirt dirt, IFarmer farmer)
        {
        }
    }

    public interface IProvolone
    {
    }

    public class Provolone : IProvolone
    {
        public Provolone(IMilk milk)
        {
        }
    }

    public interface IMilk
    {
    }

    public class Milk : IMilk
    {
        public Milk(ICow cow, IFarmer farmer)
        {
        }
    }

    public interface IHam
    {
    }

    public class Ham : IHam
    {
        public Ham(IPig pig, IButcher butcher)
        {
        }
    }
}