namespace PolarH10
{
    public class MidiConnector
    {
        private readonly MidiSender midiSender;

        public MidiConnector(MidiSender midiSender)
        {
            this.midiSender = midiSender;    
        }

        public void ReceiveData (HrPayload hrPayload)
        {
            midiSender.SendMidiMsg(hrPayload.Heartrate);
        }
    }
}