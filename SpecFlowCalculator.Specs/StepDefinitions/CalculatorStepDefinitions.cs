using ClassLibrary1;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.StepDefinitions
{
	[Binding]
	public sealed class CalculatorStepDefinitions
	{
		private readonly Calculator _calculator = new Calculator();
		// For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

		private int _result;

		private readonly ScenarioContext _scenarioContext;


		public CalculatorStepDefinitions(ScenarioContext scenarioContext)
		{
			_scenarioContext = scenarioContext;
		}

		[Given("the first number is (.*)")]
		public void GivenTheFirstNumberIs(int number)
		{
			_calculator.FirstNumber = number;
			_calculator.result1 = number;	
			

		}

		[Given("the second number is (.*)")]
		public void GivenTheSecondNumberIs(int number)
		{
			_calculator.SecondNumber = number;
			//TODO: implement arrange (precondition) logic
		}

		[When(@"operation \+ is done to the number (.*)")]
		public void WhenOperationAddIsDoneToTheNumber(int number)
		{
			_result = _calculator.Add(number);
			
		}

		[When(@"operation - is done to the number (.*)")]
		public void WhenOperationSubIsDoneToTheNumber(int number)
		{
			_result = _calculator.Subtract(number);
			
		}

		[When(@"operation / is done to the number (.*)")]
		public void WhenOperationDivIsDoneToTheNumber(int p0)
		{
			_result = _calculator.DivideInt(p0);
		}

		[When(@"operation % is done to the number (.*)")]
		public void WhenOperationModIsDoneToTheNumber(int p0)
		{
			_result = _calculator.modDivide(p0);
		}




		[When("the two numbers are added")]
		public void WhenTheTwoNumbersAreAdded()
		{
			_result = _calculator.Add();
		}

		[When(@"the two numbers are subtracted")]
		public void WhenTheTwoNumbersAreSubtracted()
		{
			_result = _calculator.Subtract();
		}

		[When(@"the two numbers are multiplied")]
		public void WhenTheTwoNumbersAreMultiplied()
		{
			_result = _calculator.multiply();
		}


		[Then("the result should be (.*)")]
		public void ThenTheResultShouldBe(int result)
		{
			_result.Should().Be(result);
		}
	}
}