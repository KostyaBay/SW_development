using System;

public class Calculator
{
    private readonly ILogger _logger;

    public Calculator(ILogger logger)
    {
        _logger = logger;
    }

    public double deriv_sin(double x)
    {
        var result = Math.Cos(x);
        _logger.Log(result);
        return result;
    }

    public double deriv_cos(double x)
    {
        var result = (-Math.Sin(x));
        _logger.Log(result);
        return result;
    }

    public double deriv_exp(double x)
    {
        var result = Math.Exp(x);
        _logger.Log(result);
        return result;
    }
}
