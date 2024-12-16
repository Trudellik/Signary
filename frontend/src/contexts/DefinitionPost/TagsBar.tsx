import React from 'react'
import { Tag, Tooltip } from 'antd'

interface TagsBarProps {
  tags: string[]
}

const TagsBar = ({ tags }:TagsBarProps) => {
  return (
    <div>
      {tags.map((tag) => (
        <Tooltip title="Description" placement='bottom'>
          <Tag color='teal'>{tag}</Tag>
        </Tooltip>
      ))}
    </div>
  )
}

export default TagsBar