using configs.classes.structures;

namespace configs.classes.interfacing
{
    /**
     * API Headers
     */
    public abstract class config_headers : iconfigwriter
    {
        public abstract structure_headers read();
        public abstract bool write(structure_headers s);
    }
}
