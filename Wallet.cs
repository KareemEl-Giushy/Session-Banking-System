namespace GateWay {
    class Wallet {
        public float balance {
            set; get;
        }

        int cardNumber;

        public Wallet() {
            balance = 0;
        }

        public Wallet(float initBalance) {
            balance = initBalance;
        }
    }
}