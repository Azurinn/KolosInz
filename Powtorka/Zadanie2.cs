namespace Powtorka;

// Korzystając ze wzorca dekorator przygotuj zestaw klas opisujących choinkę, 
// do której można dodać lampki, łańcuchy, anielskie włosy, różnego rodzaju bombki, 
// itd. Wersje podstawowe to świetk i jodła kaukaska. W ramach testów przygotuj choinkę 
// z dwoma łańcuchami, zielonymi bombkami i lampkami.
public class Zadanie2
{
    public abstract class Tree
    {
        public abstract string Describe();
    }

    public class Spurce : Tree
    {
        public override string Describe()
        {
            return "Świerk";
        }
    }

    public class CaucasianFir : Tree

    {
        public override string Describe()
        {
            return "Jodła kałaska";
        }
    }

    public abstract class TreeDecorator : Tree
    {
        protected Tree _tree;

        public TreeDecorator(Tree tree)
        {
            _tree = tree;
        }
    }

    public class Lights : TreeDecorator
    {
        public Lights(Tree tree) : base(tree)
        {
        }

        public override string Describe()
        {
            return _tree.Describe() + ", z lampkami";
        }
    }

    public class Chains : TreeDecorator
    {
        public Chains(Tree tree) : base(tree)
        {
        }

        public override string Describe()
        {
            return _tree.Describe() + ", z łańcuchami";
        }
    }

    public class AngelHairs : TreeDecorator
    {
        public AngelHairs(Tree tree) : base(tree)
        {
        }

        public override string Describe()
        {
            return _tree.Describe() + ", z włosami anioła";
        }
    }

    public class Bauble : TreeDecorator
    {
        private readonly string _color;

        public Bauble(Tree tree, string color) : base(tree)
        {
            _color = color;
        }

        public override string Describe()
        {
            return _tree.Describe() + $",z {_color} bombkami";
        }
    }
}