using System.Collections.Generic;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Molecule_to_atoms
{
    public class Kata
    {
        public static Dictionary<string, int> ParseMolecule(string formula)
        {
            Dictionary<string, int> atoms = new Dictionary<string, int>();
            Regex rx = new Regex(@"\(([^)]?)\)");

            string value = rx.Match(formula).Groups[1].Value;
            return null;
        }
    }

    [TestFixture]
    public class ParseMoleculeTest
    {
        [Test]
        public void DescriptionExampleTests()
        {
            CollectionAssert.AreEquivalent(new Dictionary<string, int> {{"H", 2}, {"O", 1}}, Kata.ParseMolecule("H2O"));
            CollectionAssert.AreEquivalent(new Dictionary<string, int> {{"Mg", 1}, {"O", 2}, {"H", 2}}, Kata.ParseMolecule("Mg(OH)2"));
            CollectionAssert.AreEquivalent(new Dictionary<string, int> {{"K", 4}, {"O", 14}, {"N", 2}, {"S", 4}}, Kata.ParseMolecule("K4[ON(SO3)2]2"));
        }
    }
}