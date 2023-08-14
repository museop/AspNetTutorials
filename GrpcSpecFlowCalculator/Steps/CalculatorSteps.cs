using Grpc.Net.Client;
using TechTalk.SpecFlow;

using GrpcCalculatorServer;
using NUnit.Framework;

namespace GrpcSpecFlowCalculator.Steps;

[Binding]
public class CalculatorSteps
{
    private GrpcChannel _channel = null!;
    private Calculator.CalculatorClient _client = null!;
    private int _result;

    [Given(@"the calculator service is available")]
    public void GivenTheCalculatorServiceIsAvailable()
    {
        _channel = GrpcChannel.ForAddress("http://localhost:5051");
        _client = new Calculator.CalculatorClient(_channel);
    }

    [When(@"I add (\d+) and (\d+)")]
    public void WhenIAddAnd(int num1, int num2)
    {
        var request = new AddRequest { Num1 = num1, Num2 = num2 };
        var response = _client.Add(request);
        _result = response.Result;
    }

    [Then(@"the result should be (\d+)")]
    public void ThenTheResultShouldBe(int expected)
    {
        Assert.AreEqual(expected, _result);
    }
}
