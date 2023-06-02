using System;

public class Program {
    static int Main(string[] args) {
        int playerHp = 70;
        int enemyHp = 50;

        while (playerHp > 0 && enemyHp > 0) {
            Console.WriteLine($"Player hp: {playerHp}");
            Console.WriteLine($"Enemy hp: {enemyHp}");
            Console.WriteLine("Choose: Attack or Block");
            string choice = Console.ReadLine();

            if (choice.Equals("Attack", StringComparison.OrdinalIgnoreCase)) {
                int playerAttack = new Random().Next(1, 10);
                enemyHp -= playerAttack;
                Console.WriteLine($"You've dealt {playerAttack} damage");
            }

            // Enemy's turn
            Console.WriteLine("Enemy's Turn");
            int enemyAttack = new Random().Next(1, 10);
            playerHp -= enemyAttack;
            Console.WriteLine($"Enemy attack dealt {enemyAttack} damage");


            if (choice.Equals("Block", StringComparison.OrdinalIgnoreCase)) {
                playerHp -= new Random().Next(1, 5);
                Console.WriteLine($"You've blocked {enemyAttack} damage");
            }
            
            // int enemyHeal = new Random().Next(9, 20);
            // enemyHp += enemyHeal;
            // Console.WriteLine($"Enemy healed");
       
        }

        // Game over and victory conditions
        if (enemyHp <= 0) {
            Console.WriteLine("Enemy has been slayed");
                Console.WriteLine("Congratulations! You won!");
            }
            else {
                Console.WriteLine("Game Over");
            }

        return 0;
    }
}
