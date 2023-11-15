namespace Modbus.Processor.Communicators;

public interface ITcpServerCommunicator : ICommunicator
{
    Task<bool> AcceptClientAsync(int timeout);

    void CloseClient();
}