using TechTalk.SpecFlow;

namespace Behavior.Steps
{
    [Binding]
    public class NewLinesStepDefinitions
    {
        [Given(@"from (.*)")]
        public void GivenFrom(int from)
        {
            ScenarioContext.StepIsPending();
        }

        [Given(@"to (.*)")]
        public void GivenTo(int to)
        {
            ScenarioContext.StepIsPending();
        }

        [When(@"the program is run")]
        public void WhenTheProgramIsRun()
        {
            ScenarioContext.StepIsPending();
        }

        [Then(@"the amount of lines should be (.*)")]
        public void ThenTheAmountOfLinesShouldBe(int lineCount)
        {
            ScenarioContext.StepIsPending();
        }
    }
}