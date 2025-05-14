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

    public enum TerminalStatus
    {
        CARD_ENTRY_REQUESTED
        , CARD_INSERTED
        , CARD_TAPPED
        , CARD_SWIPED
        , MANUAL_INPUT
        , QRCODE_TXN
        , DONATION_REQUESTED
        , DONATION_ACCEPTED
        , DONATION_DECLINED
        , TIP_REQUESTED
        , TIP_ACCEPTED
        , TIP_DECLINED
        , LOYALTY_IN_PROGRESS
        , PIN_REQUESTED
        , PIN_ENTRY_FAIL
        , PIN_ENTRY_SUCCESS
        , COMMUNICATE_WITH_HOST
    }



    public class Return2IdleResponse
    {
        public string txnDateTime { get; set; }
        public string txnPosTxnId { get; set; }
        public string txnReturnCode { get; set; }
        public string txnType { get; set; }
    }

    class ErrorCodes
    {
        public static Dictionary<string, string> _Errors = new Dictionary<string, string>() {
                                    {"00000000", "success or approval"},
                                    {"E0000000", "TERMINAL ERROR OFFSET"},
                                    {"E0000001", "initialization fail (bad config file…etc )"},
                                    {"E0000002", "invalid parameter or invalid command format (JSON format)"},
                                    {"E0000003", "unsupported function"},
                                    {"E0000004", "device busy"},
                                    {"E0000005", "network error"},
                                    {"E0000006", "poll card timeout, no card detected (default is 120s)"},
                                    {"E0000007", "host response timeout, no response from host (default is 60s)"},
                                    {"E0000008", "user cancel"},
                                    {"E0000009", "declinded by local (card or terminal), if declined by host, please ref."},
                                    {"E8xxxxxx ", "error code"},
                                    {"E000000A", "read card fail"},
                                    {"E000000B", "contactless collision (multiple card)"},
                                    {"E000000C", "transaction not found"},
                                    {"E000000D", "settlement fail"},
                                    {"E000000E", "repeated transaction ID (txnPosTxnId)"},
                                    {"E000000F", "printer out of paper"},
                                    {"E0000010", "printer error"},
                                    {"E0000011", "Transaction already voided"},
                                    {"E0000012", "Transaction declined by card"},
                                    {"E0000013", "Trasnaction declined by signature failed"},
                                    {"E0000014", "AVS declined"},
                                    {"E0000015", "Permission Denied"},
                                    {"E0000016", "Advice failed"},
                                    {"E0000017", "Bad MAC"},
                                    {"E0000018", "Reversal Fail"},
                                    {"E0000019", "DCC Cancel"},
                                    {"E000001A", "Barcode Not Created"},
                                    {"E000001B", "Barcode Insufficient Memory"},
                                    {"E000001C", "Barcode Already Created"},
                                    {"E000001D", "Barcode Folder Path Error"},
                                    {"E000001E", "Barcode Deviceid Error"},
                                    {"E000001F", "Barcode Devicetype Error"},
                                    {"E0000020", "Barcode Customerid Error"},
                                    {"E0000021", "Barcode Deactivation Not Allowed"},
                                    {"E0000022", "Barcode Curl Failure"},
                                    {"E0000023", "Barcode Flexera Failure"},
                                    {"E0000024", "Barcode Invalid Key"},
                                    {"E0000025", "Barcode Clock Windback Detected"},
                                    {"E0000026", "Barcode No License Available"},
                                    {"E0000027", "Barcode Flexera Com"},
                                    {"E0000028", "Barcode Flexera No Response"},
                                    {"E0000029", "Barcode Not Activated"},
                                    {"E000002A", "Please re-try Settle"},
                                    {"E000002B", "Amount input limit"},
                                    {"E000002C", "Trasnaction not accepted"},
                                    {"E000002D", "Payment Service Not Activate"},
                                    {"E000002E", "Main Service Not Draw Overlay Permission"},
                                    {"E000002F", "Payment Service Not Draw Overlay Permission"},
                                    {"E8000000", "HOST ERROR OFFSET"},
                                    {"FFFFFFFF", "STATUS FEEDBACK from payment application" }};
        public static string GetErrorMessage(string code)
        {
            if (_Errors.ContainsKey(code))
                return _Errors[code];
            else return "Undefined";
        }
    }
    class Return2IdleRequest 
    {
        public string txnPosTxnId { get; set; }
        public string txnType { get; set; } = "return2Idle";
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
        public TransactionHandler(string address, int port) { }
        PosNetworkConnection conn = null;
    }
}
