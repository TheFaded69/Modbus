﻿using Modbus.Requests;
using Modbus.Responses;
using Modbus.Types;

namespace Modbus;

public class ModbusRequestResponse
{
    public ModbusRequestResponse(BaseRequest request)
    {
        Request = request;
    }

    public AutoResetEvent Event { get; } = new(false);

    /// <summary>
    /// ответ
    /// </summary>
    public BaseResponse Response { get; set; }

    /// <summary>
    /// запрос
    /// </summary>
    public BaseRequest Request { get; set; }

    /// <summary>
    /// Результат запроса
    /// </summary>
    public ModbusRequestResult RequestResult { get; set; }
}