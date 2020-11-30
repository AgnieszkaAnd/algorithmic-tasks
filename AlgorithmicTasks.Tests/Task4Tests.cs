using System.Linq;
using AlgorithmicTasks.Tasks;
using NUnit.Framework;

namespace AlgorithmicTasks.Tests
{
    /// <summary>
    /// Testy jednostkowe do funkcji IleJestWDrugiejTablicy(z pytania nr 4).
    /// U¿ywam unikalnych nazw funkcji zgodnie dobrymi praktykami BDD (konwencja Gherkina):
    /// Given: przypadek testowy(scenariusz u¿ycia)
    /// And: opcjonalnie
    /// When: co jest testowane/nazwa metody IleJestWDrugiejTablicy
    /// Then: oczekiwany wynik)
    /// </summary>
    public class Task4Tests
    {
        [TestCase(new string[] {"aaa", "bbb"}, new string[] { "c", "d", "eee"})]
        [TestCase(new string[] { "" }, new string[] { "c", "d", "eee" })]
        [TestCase(new string[] { null }, new string[] { "null" })]
        [TestCase(new string[] { "aaa", "bbb", "null" }, new string[] { null })]
        public void GivenZeroElementsFromTable1ExistAlsoInTable2_WhenIleJestWDrugiejTablicyIsCalled_ThenShouldReturnZero(
            string[] table1,
            string[] table2)
        {
            int result = Task4.IleJestWDrugiejTablicy(table1, table2);

            Assert.AreEqual(0, result);
        }

        [TestCase(new string[] { "aaa", "aaa", "bbb" }, new string[] { "aaaa", "d", "eee" })]
        [TestCase(new string[] { "x", "x", "x" }, new string[] { "c", "d", "xfhfhfhf", "eee" })]
        public void GivenElementFromTable1IsSubstringOfElementInTable2_AndIsNotExactMatch_AndNoOtherMatchesFound_WhenIleJestWDrugiejTablicyIsCalled_ThenShouldReturnZero(
            string[] table1,
            string[] table2)
        {
            int result = Task4.IleJestWDrugiejTablicy(table1, table2);

            Assert.AreEqual(0, result);
        }

        [TestCase(new string[] { "aaa", "aaa", "bbb" }, new string[] { "aaa", "d", "eee" }, "aaa")]
        [TestCase(new string[] { "x", "x", "x" }, new string[] { "c", "d", "x", "eee" }, "x")]
        [TestCase(new string[] { null, "hi", null }, new string[] { "c", "d", null, "eee" }, null)]

        public void GivenOneElementOccursMultipleTimesInTable1_AndItExistAlsoInTable2_AndNoOtherMatchesFound_WhenIleJestWDrugiejTablicyIsCalled_ThenShouldReturnNumberOfOccurencesOfThatElementInTable1(
            string[] table1,
            string[] table2,
            string matchingElement)
        {
            int result = Task4.IleJestWDrugiejTablicy(table1, table2);

            Assert.AreEqual(table1.Count(x => x == matchingElement), result);
        }

        [TestCase(new string[] { "aaa", "aaa", "bbb" }, new string[] { "aaa", "aaa", "bbb" })]
        [TestCase(new string[] { "x", "xs", "sx" }, new string[] { "x", "xs", "sx" })]
        public void GivenTable1AndTable2AreEqual_WhenIleJestWDrugiejTablicyIsCalled_ThenShouldReturnLengthOfTable1(
            string[] table1,
            string[] table2)
        {
            int result = Task4.IleJestWDrugiejTablicy(table1, table2);

            Assert.AreEqual(table1.Length, result);
        }

        [TestCase(new string[] { "aaa", "aaa", "bbb" }, new string[] { "bbb", "aaa", "aaa" })]
        [TestCase(new string[] { "x", "xs", "sx" }, new string[] { "sx", "xs", "x" })]
        public void GivenTable1AndTable2AreInversedTables_WhenIleJestWDrugiejTablicyIsCalled_ThenShouldReturnLengthOfTable1(
            string[] table1,
            string[] table2)
        {
            int result = Task4.IleJestWDrugiejTablicy(table1, table2);

            Assert.AreEqual(table1.Length, result);
        }
    }
}