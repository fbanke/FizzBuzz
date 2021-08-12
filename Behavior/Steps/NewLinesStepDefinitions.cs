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

        [When(@"running the program")]
        public void WhenRunningTheProgram()
        {
            ScenarioContext.StepIsPending();
        }

        [Then(@"the result should be (.*) lines")]
        public void ThenTheResultShouldBeLines(int lineCount)
        {
            ScenarioContext.StepIsPending();
        }
    }
}