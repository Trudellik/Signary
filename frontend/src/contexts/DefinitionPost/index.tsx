import React from 'react'
import DefinitionVideo from './DefinitionVideo'
import MouthingRange from './MouthingRange'
import TagsBar from './TagsBar'
import SynonymBar from './SynonymBar'

const DefinitionPost
 = () => {
  const definition = {
    mouhtings: ["nothing", "ok"],
    definitionUrl: "https://player.vimeo.com/video/163721649",
    synonyms: ["nul", "bold"],
    tags: ["gammel", "stødende"]
  }
  return (
    <div>
        <MouthingRange mouthings={definition.mouhtings}/>
        <TagsBar tags={definition.tags} />
        <DefinitionVideo url={definition.definitionUrl} />
        <SynonymBar synonyms={definition.synonyms} />
    </div>
  )
}

export default DefinitionPost
