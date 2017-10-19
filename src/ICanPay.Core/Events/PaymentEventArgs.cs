using System;

namespace ICanPay.Core
{
    /// <summary>
    /// ֧���¼����ݵĻ���
    /// </summary>
    public abstract class PaymentEventArgs : EventArgs
    {

        #region ˽���ֶ�

        protected GatewayBase gateway;
        private string notifyServerHostAddress;

        #endregion

        #region ���캯��

        /// <summary>
        /// ��ʼ��֧���¼����ݵĻ���
        /// </summary>
        /// <param name="gateway">֧������</param>
        public PaymentEventArgs(GatewayBase gateway)
        {
            this.gateway = gateway;
            notifyServerHostAddress = HttpUtil.LocalIpAddress.ToString();
        }

        #endregion

        #region ����

        /// <summary>
        /// ����֧��֪ͨ������IP��ַ
        /// </summary>
        public string NotifyServerHostAddress
        {
            get
            {
                return notifyServerHostAddress;
            }
        }

        /// <summary>
        /// ֧�����ص�����
        /// </summary>
        public GatewayData GatewayData
        {
            get
            {
                return gateway.GatewayData;
            }
        }

        #endregion
    }
}