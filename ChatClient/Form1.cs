

namespace ChatClient

{
    using System;
    using System.IO;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {

        private TcpClient client;
        private NetworkStream stream;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                await client.ConnectAsync("127.0.0.1", 5000);
                stream = client.GetStream();

               
                _ = ReceiveMessagesAsync();

                AppendMessage("Подключено к серверу.");
            }
            catch (Exception ex)
            {
                AppendMessage($"Ошибка подключения: {ex.Message}");
            }
        }

        private async void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                string message = MessageTextBox.Text;
                byte[] data = Encoding.UTF8.GetBytes(message);
                await stream.WriteAsync(data, 0, data.Length);
                AppendMessage($"Вы: {message}");
                MessageTextBox.Clear();
            }
            catch (Exception ex)
            {
                AppendMessage($"Ошибка отправки: {ex.Message}");
            }
        }

        private async Task ReceiveMessagesAsync()
        {
            byte[] buffer = new byte[1024];
            try
            {
                while (true)
                {
                    
                    await Task.Delay(100);

                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    AppendMessage(message);
                }
            }
            catch (Exception)
            {
                AppendMessage("Отключено от сервера.");
            }
        }

        private void AppendMessage(string message)
        {
            if (ChatTextBox.InvokeRequired)
            {
                ChatTextBox.Invoke(new Action(() => ChatTextBox.AppendText(message + "\n")));
            }
            else
            {
                ChatTextBox.AppendText(message + "\n");
            }
        }

        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            
            base.OnFormClosing(e);
        }

    }

}
