public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What song did you identify with today?",
        "how was the weather today?",
        "what are you grateful for today?",
        "What mood predominated the most this day?",
        "What made you happiest today?",
        "Who you shared with today and what you did (include sharing with yourself)?",
        "What achievement were you able to accomplish today (tidying up, doing homework, getting up, etc.)?",
        "What would you like to change about your day?",
        "any spiritual experience today?",
    };

    public Random _random = new Random();
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}