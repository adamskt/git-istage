        public static string ComputePatch(PatchDocument document, IEnumerable<int> lineIndexes, PatchDirection direction)
            var isUndo = direction == PatchDirection.Reset ||
                         direction == PatchDirection.Unstage;

                                         kind == PatchLineKind.Removal && (!isUndo || lineSet.Contains(i)) ||
                                         kind == PatchLineKind.Addition && (isUndo && !lineSet.Contains(i));
                                       .Where(k => k.IsAdditionOrRemoval())
                        else if (!isUndo && kind == PatchLineKind.Removal ||
                                 isUndo && kind == PatchLineKind.Addition)
        public static void ApplyPatch(string pathToGit, string workingDirectory, string patch, PatchDirection direction)
            var isUndo = direction == PatchDirection.Reset ||
                         direction == PatchDirection.Unstage;
            var reverse = isUndo ? "--reverse" : string.Empty;
            var cached = direction == PatchDirection.Reset ? string.Empty : "--cached";
            var arguments = $@"apply {cached} {reverse} --whitespace=nowarn ""{patchFilePath}""";