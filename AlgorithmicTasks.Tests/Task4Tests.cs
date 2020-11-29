using System.Linq;
using AlgorithmicTasks.Tasks;
using NUnit.Framework;

namespace AlgorithmicTasks.Tests
{
    //Napisz przynajmniej 3 testy jednostkowe do funkcji IleJestWDrugiejTablicy(z poprzedniego pytania).
    //W tym zadaniu oceniane jest pokrycie ró¿nych przypadków,
    //a kluczowe jest u¿ycie unikalnych nazw funkcji testowych zgodnie dobrymi praktykami BDD.
    //A wiêc nazwa funkcji testowej musi mówiæ co jest testowane, jaki przypadek testowy(scenariusz u¿ycia)
    //jest testowany oraz jaki jest oczekiwany wynik."
    public class Task4Tests
    {
        [TestCase(new string[] {"aaa", "bbb"}, new string[] { "c", "d", "eee"})]
        [TestCase(new string[] { "" }, new string[] { "c", "d", "eee" })]
        [TestCase(new string[] { "aaa", "bbb" }, new string[] { "", "" })]

        public void GivenZeroElementsFromTable1ExistAlsoInTable2_WhenIleJestWDrugiejTablicyIsCalled_ThenShouldReturnZero(
            string[] table1,
            string[] table2)
        {
            int result = Task4.IleJestWDrugiejTablicy(table1, table2);

            Assert.AreEqual(0, result);
        }

        [TestCase(new string[] { "aaa", "aaa", "bbb" }, new string[] { "aaa", "d", "eee" }, "aaa")]
        [TestCase(new string[] { "x", "x", "x" }, new string[] { "c", "d", "x", "eee" }, "x")]
        public void GivenOneElementOccursMultipleTimesInTable1_AndItExistAlsoInTable2_AndNoOtherMatchesFound_WhenIleJestWDrugiejTablicyIsCalled_ThenShouldReturnNumberOfOccurencesOfThatElementInTable1(
            string[] table1,
            string[] table2,
            string matchingElement)
        {
            int result = Task4.IleJestWDrugiejTablicy(table1, table2);

            Assert.AreEqual(table1.Count(x => x == matchingElement), result);
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
        public void GivenTable1AndTable2AreInTheOpposite_WhenIleJestWDrugiejTablicyIsCalled_ThenShouldReturnLengthOfTable1(
            string[] table1,
            string[] table2)
        {
            int result = Task4.IleJestWDrugiejTablicy(table1, table2);

            Assert.AreEqual(table1.Length, result);
        }

    }
}