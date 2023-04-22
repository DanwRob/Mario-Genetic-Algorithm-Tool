using System.Collections.Generic;

namespace GeneticAlgorithmTool
{
    public class FrameAction
    {
        private int frameCount;
        public FrameAction(int totalFrames, IEnumerable<Buttons> actions)
        {
            TotalFrames = totalFrames;
            Actions = actions;
            frameCount = 1;
        }

        public FrameAction Clone() => new(TotalFrames, Actions);

        public void AdvanceFrame() => frameCount++;

        public bool IsFinishAction() => frameCount >= TotalFrames;

        public int TotalFrames { get; }
        public IEnumerable<Buttons> Actions { get; }

    }
}
