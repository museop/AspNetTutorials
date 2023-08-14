using Grpc.Core;
using GrpcCalculatorServer;

namespace GrpcCalculatorServer.Services;

public class CalculatorService : Calculator.CalculatorBase
{
    public override Task<AddResponse> Add(AddRequest request, ServerCallContext context)
    {
        int result = request.Num1 + request.Num2;
        return Task.FromResult(new AddResponse { Result = result });
    }
}
