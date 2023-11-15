using Modbus.Attributes;

namespace Modbus.Responses;

/// <summary>
/// Ошибка
/// </summary>
public class ErrorResponse : BaseResponse
{
    /// <summary>
    /// код ошибки
    /// </summary>
    [SerializationOrder(2)]
    public byte ExceptionCode { get; set; }
}