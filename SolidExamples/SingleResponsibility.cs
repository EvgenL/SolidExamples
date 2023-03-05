public static class SingleResponsibility
{
    public static void Test()
    {
        var gameController = new GameController();
        gameController.Win();
        gameController.GivePlayerReward(9999);
        gameController.AddPlayerHp(-1);
        gameController.Lose();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        var winController = new WinController();
        gameController.Win();
        
        var reward = new RewardController();
        reward.GivePlayerReward(9999);
        
        var hp = new HpController();
        hp.AddPlayerHp(-1);
        
        winController.Lose();
        
    }
}







public class GameController
{
    public void Win()
    {
    }
    
    public void Lose()
    {
    }
    
    public void AddPlayerHp(int hp)
    {
    }
    
    public void GivePlayerReward(int hp)
    {
    }
}











// refactor: extract class











public class WinController
{
    public void Win()
    {
    }
    
    public void Lose()
    {
    }
}

public class RewardController
{
    
    public void GivePlayerReward(int hp)
    {
    }
}

public class HpController
{
    public void AddPlayerHp(int hp)
    {
    }
}




