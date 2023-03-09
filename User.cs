namespace GateWay {
    class User {
        int id;
        string fullName;
        Wallet wallet;

        public User() {
            id = 0;
            fullName = "John Doe";
            wallet = new Wallet();
        }

        public User(Wallet w) {
            id = 0;
            fullName = "John Doe";
            Register(w);
        }

        public void Register(Wallet w) {
            this.wallet = w;
        }

        public void Deposit(float amount) {
            wallet.balance += amount;
        }

        public float Withdraw(float amount) {
            wallet.balance -= amount;

            return wallet.balance;
        }

        public float BQ() {
            return wallet.balance;
        }
    }
}