using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CastlePaySolutions.Saturn1X
{
    public class SaleRequest
    {
        public string txnPosTxnId { get; set; } //txnPosTxnId” should be unique per request packet, the value is “000001” ~ “999999”,
                                                // the response packet will return the same value as sent in the request packet
        public string txnType { get; set; } = "sale";
        public string txnAmtBase { get; set; }
        public string txnAmtTip { get; set; }
    }

    public class SaleRequestResponse
    {
        public string txnAmtBase { get; set; }
        public string txnAmtCashback { get; set; }
        public string txnAmtTip { get; set; }
        public string txnAmtTrans { get; set; }
        public string txnApprovalCode { get; set; }
        public string txnCardBrand { get; set; }
        public string txnDateTime { get; set; }
        public string txnEntryMode { get; set; }
        public string txnHostMsg { get; set; }
        public string txnMaskedCardNum { get; set; }
        public string txnMid { get; set; }
        public string txnPosTxnId { get; set; }
        public string txnReturnCode { get; set; }
        public string txnStan { get; set; }
        public string txnTid { get; set; }
        public string txnType { get; set; }
    }


    public class RefundRequest
    {
        public string txnPosTxnId { get; set; }
        public string txnType { get; set; } = "refund";
        public string txnAmtTrans { get; set; } //  Final total transaction amount with 2 decimal digits.The
                                                //  value includes tip and cashback amout e.g. “150.00”.
                                                //  Amount is equal to txnAmtBase + txnAmtTip + txnAmtCashback
    }

    public class SettlementRequest
    {
        public string txnPosTxnId { get; set; }
        public string txnType { get; set; } = "settlement";
    }

    public class SettlementRequestResponse
    {
        public List<TxnSettleInfo> txnSettleInfo { get; set; }
        public string txnDateTime { get; set; }
        public string txnPosTxnId { get; set; }
        public string txnReturnCode { get; set; }
        public string txnStan { get; set; }
        public string txnType { get; set; }
    }

    public class TxnSettleInfo
    {
        public string txnAcquirerName { get; set; }
        public string txnApprovalCode { get; set; }
        public string txnDateTime { get; set; }
        public string txnHostMsg { get; set; }
        public string txnMid { get; set; }
        public string txnPosTxnId { get; set; }
        public string txnReturnCode { get; set; }
        public string txnStan { get; set; }
        public string txnTid { get; set; }
        public string txnTotalRefundAmt { get; set; }
        public string txnTotalRefundCnt { get; set; }
        public string txnTotalSaleAmt { get; set; }
        public string txnTotalSaleCnt { get; set; }
        public string txnTotalSettleAmt { get; set; }
        public string txnTotalSettleCnt { get; set; }
        public string txnType { get; set; }
    }



    public class RefundRequestResponse
    {
        public string txnAmtBase { get; set; }
        public string txnAmtCashback { get; set; }
        public string txnAmtTip { get; set; }
        public string txnAmtTrans { get; set; }
        public string txnApprovalCode { get; set; }
        public string txnCardBrand { get; set; }
        public string txnDateTime { get; set; }
        public string txnEntryMode { get; set; }
        public string txnHostMsg { get; set; }
        public string txnMaskedCardNum { get; set; }
        public string txnMid { get; set; }
        public string txnPosTxnId { get; set; }
        public string txnReturnCode { get; set; }
        public string txnStan { get; set; }
        public string txnTid { get; set; }
        public string txnType { get; set; }
    }


    public class RequestGetDataResponse
    {
        public List<TxnHostInfo> txnHostInfo { get; set; }
        public string infAndroidVersion { get; set; }
        public string infAppVersion { get; set; }
        public string infEmvVersion { get; set; }
        public string infEmvclVersion { get; set; }
        public string infSecureModuleVersion { get; set; }
        public string txnDateTime { get; set; }
        public string txnPosTxnId { get; set; }
        public string txnType { get; set; }
    }
    public class RequestGetData
    {
        public string txnPosTxnId { get; set; }
        public string txnType { get; set; }
    }
    public class TxnHostInfo
    {
        public string txnAcquirerName { get; set; }
        public string txnMid { get; set; }
        public string txnTid { get; set; }
    }


    class TransactionHandler
    {
    }
}
