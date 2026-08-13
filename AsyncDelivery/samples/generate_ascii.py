import os

# ASCII art font: 5 lines per character (matching the original style)
FONT = {
    'A': ['  _  ', ' / \\ ', '|   |', '|___|', '|   |'],
    'B': [' ___ ', '| _ )', '| _ \\', '|___/', '|___\\'],
    'C': [' ___ ', '/ __|', '| (__', ' \\__ \\', '|___/'],
    'D': [' ___ ', '| _ \\', '|   /', '|   \\', '|_|_\\'],
    'E': [' ___ ', '| __|', '| _| ', '|___|', '|___|'],
    'F': [' ___ ', '| __|', '| _| ', '| |  ', '|_|  '],
    'G': [' ___ ', '/ __|', '| (_ |', ' \\__/', '|___|'],
    'H': [' _   _', '| | | |', '| |_| |', '|  _  |', '|_| |_|'],
    'I': [' ___ ', '|_ _|', ' | | ', ' | | ', '|___|'],
    'J': ['   _ ', '  | |', '  | |', ' _| |', '|___/'],
    'K': [' _  __', '| |/ /', '|   < ', '| |\\ \\', '|_| \\_\\'],
    'L': [' _    ', '| |   ', '| |   ', '| |__ ', '|____|'],
    'M': [' __  __', '|  \\/  |', '| |\\/| |', '| |  | |', '|_|  |_|'],
    'N': [' _   _', '| \\ | |', '|  \\| |', '| |\\  |', '|_| \\_|'],
    'O': ['  __  ', ' /  \\ ', '| () |', ' \\__/ ', '|    |'],
    'P': [' ___ ', '| _ \\', '|   /', '|_|\\ ', '|___|'],
    'Q': ['  ___  ', ' / _ \\ ', '| (_) |', ' \\__\\/', '    \\_\\'],
    'R': [' ___ ', '| _ \\', '|   /', '|_|\\ ', '|_| \\_\\'],
    'S': [' ___ ', '/ __|', '\\__ \\', '|___/', '|___|'],
    'T': [' _____', '|_   _|', '  | |  ', '  | |  ', '  |_|  '],
    'U': [' _   _', '| | | |', '| |_| |', '|  _  |', '|_| |_|'],
    'V': [' _   _', '| | | |', '| |_| |', ' \\   / ', '  |_|  '],
    'W': [' _    _', '| |  | |', '| |__| |', '|  __  |', '|_|  |_|'],
    'X': [' _   _', ' \\ / /', '  | | ', ' / \\ \\', '|_| |_\\'],
    'Y': [' _   _', ' \\ / /', '  | | ', '  | | ', '  |_| '],
    'Z': [' ___ ', '/ __|', ' \\__ \\', '|___/', '|___|'],
    '0': ['  __  ', ' /  \\ ', '| () |', '| () |', ' \\__/ '],
    '1': ['  _  ', ' / | ', ' | | ', ' | | ', ' |_| '],
    '2': [' ___ ', '|_  |', '  / /', ' / _|', '|___|'],
    '3': [' ___ ', '|_  |', ' _|_|', '|___|', '|___|'],
    '4': [' _  _', '| || |', '| __ |', '|_||_|', '|_||_|'],
    '5': [' ___ ', '| __|', '|__ \\', '|___/', '|___|'],
    '6': ['  __ ', ' / / ', '/ _| ', '\\__ \\', '|___/'],
    '7': [' ___ ', '|_  |', '  / /', ' / _|', '|___|'],
    '8': ['  __  ', ' /__\\ ', '| () |', '| () |', ' \\__/ '],
    '9': ['  __  ', ' /__\\ ', '| () |', ' \\__|', ' |____'],
    ' ': ['      ', '      ', '      ', '      ', '      '],
}

def text_to_ascii_art(text):
    text = text.upper()
    lines = ['', '', '', '', '']
    for ch in text:
        glyph = FONT.get(ch, FONT[' '])
        for i in range(5):
            lines[i] += glyph[i] + ' '
    return '\n'.join(lines)

# 100 different words/phrases - each unique
words = [
    "HELLO", "WORLD", "CLAUDE", "CODING", "PYTHON", "GITHUB", "DOTNET", "WINDOWS",
    "BASH", "SHELL", "LINUX", "MACOS", "SERVER", "CLIENT", "DATABASE", "NETWORK",
    "CLOUD", "DOCKER", "KUBER", "REDIS", "MYSQL", "MONGO", "NGINX", "APACHE",
    "RUST", "JAVA", "GOLANG", "SWIFT", "KOTLIN", "REACT",
    "ANGULAR", "VUE", "NODE", "DENO", "FLUTTER", "DJANGO", "FLASK", "FASTAPI",
    "SPRING", "GRADLE", "MAVEN", "GIT", "JENKINS", "ANSIBLE", "TERRAFORM",
    "PROMETHEUS", "GRAFANA", "ELASTIC", "KAFKA", "RABBITMQ",
    "AZURE", "AWS", "GCP", "ORACLE", "IBM", "INTEL", "AMD", "NVIDIA",
    "OPENAI", "DEEPSEEK", "QWEN", "LLAMA", "MISTRAL", "GEMINI",
    "MOUSE", "KEYBOARD", "MONITOR", "LAPTOP", "PHONE", "TABLET", "ROUTER",
    "SWITCH", "FIREWALL", "PROXY", "CACHE", "QUEUE", "STACK", "HEAP",
    "ARRAY", "VECTOR", "MATRIX", "TENSOR", "GRAPH", "TREE", "SORT", "MERGE",
    "QUICK", "BINARY", "LINEAR", "HASH", "MAP", "SET", "LIST", "TUPLE",
    "CLASS", "OBJECT", "METHOD", "FIELD", "ASYNC", "AWAIT", "YIELD", "BREAK",
]

# Only use as many as needed for 100 files
words = words[:100]

# Remove old files first
for f in os.listdir('.'):
    if f.startswith('ascii_') and f.endswith('.txt'):
        os.remove(f)

# Generate files
script_dir = os.path.dirname(os.path.abspath(__file__)) if '__file__' in dir() else '.'
os.chdir(os.path.dirname(os.path.abspath(__file__)))

# First remove old file_*.txt
for f in os.listdir('.'):
    if f.startswith('file_') and f.endswith('.txt'):
        os.remove(f)

for i, word in enumerate(words):
    art = text_to_ascii_art(word)
    filename = f"ascii_{word.lower()}.txt"
    with open(filename, 'w') as f:
        f.write(art)

print(f"Generated {len(words)} files.")
# Show a few examples
for w in words[:3]:
    fn = f"ascii_{w.lower()}.txt"
    with open(fn) as f:
        print(f"\n=== {fn} ===")
        print(f.read())
